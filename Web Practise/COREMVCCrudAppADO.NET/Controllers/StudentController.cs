using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using COREMVCCrudAppADO.NET.Models;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace COREMVCCrudAppADO.NET.Controllers
{
    public class StudentController : Controller
    {
        public string connectionString ="Server=DESKTOP-HD3BUG1;Database=UniversityDb;User Id=sa;Password=Bina;";
        public IActionResult Add()
        {
            ViewBag.Departments = GetDepartment();         
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            string query = "Insert into Student (Name,Email,Address,DepartmentId) Values('" + student.Name + "','" + student.Email + "','" + student.Address + "','" + student.DepartmentId + "')";
            bool IsExecute= new DatabaseHelper(connectionString).Execute(query);
            string message;
            if (IsExecute)
            {
                message = "Save successfully";
            }        
            else
            {
                message = "Save Failed";
            }
            ViewBag.Message = message;
            ViewBag.Departments = GetDepartment();
            ViewBag.Students = GetAllStudent();
            return RedirectToAction("GetAll");
        }
        public IActionResult GetAll()
        {
            var model = GetAllStudent();
            return View(model);
        } 
        public IActionResult Update(int id)
        {
            var student = GetStudent(id);
            ViewBag.Departments = GetDepartment();
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            string query ="Update student set Name='"+student.Name+"',Address='"+student.Address+"',Email='"+student.Email+"',DepartmentId='"+student.DepartmentId+"' where Id="+student.Id+"";
            bool IsExecute = new DatabaseHelper(connectionString).Execute(query);
            string message;
            if (IsExecute)
            {
                message="Update successfully";
            }
            else
            {
                message = "Update Failed";
            }
            ViewBag.Departments = GetDepartment();
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            var student = GetStudent(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            string query = "Delete from Student where id="+id+"";
            string message;
            bool IsExecute = new DatabaseHelper(connectionString).Execute(query);
            if (IsExecute)
            {
                message = "Delete successfully";
            }
            else
            {
                message = "Delete Failed";
            }
            ViewBag.Message = message;
            return RedirectToAction("GetAll");
        }
        public Student GetStudent(int id)
        {
            string connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDb;User Id=sa;Password=Bina;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "Select * from student where id = "+id+"";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            Student student = new Student();
            while (dataReader.Read())
            {
                student.Id =Convert.ToInt32(dataReader["Id"]);
                student.Address = dataReader["Address"].ToString();
                student.DepartmentId =Convert.ToInt32(dataReader["DepartmentId"]);
                student.Email = dataReader["Email"].ToString();
                student.Name = dataReader["Name"].ToString();
            }
            sqlConnection.Close();
            dataReader.Close();
            return student;
        }
        public List<Student> GetAllStudent()
        {
            string connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDb;User Id=sa;Password=Bina;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = @"select Student.Id,Student.Name,Student.Email,Student.Address,Department.Name as DeptName from Student inner join Department
                           on Student.DepartmentId = Department.Id";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (dataReader.Read())
            {
                Student student = new Student();
                student.Id =Convert.ToInt32(dataReader["Id"]);
                student.Address = dataReader["Address"].ToString();
                student.DepartmentName = dataReader["DeptName"].ToString();
                student.Email = dataReader["Email"].ToString();
                student.Name = dataReader["Name"].ToString();
                students.Add(student);
            }
            sqlConnection.Close();
            dataReader.Close();
            return students;
        }
        public List<Department> GetDepartment()
        {
            string connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDb;User Id=sa;Password=Bina;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "Select * from Department";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (dataReader.Read())
            {
                Department department = new Department();
                department.Name = dataReader["Name"].ToString();
                department.Id = Convert.ToInt32(dataReader["Id"]);
                department.ShortName = dataReader["ShortName"].ToString();
                departments.Add(department);
            }
            sqlConnection.Close();
            dataReader.Close();
            return departments;
        }
    }
}
