using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstWebApp.Models;
using System.Data.SqlClient;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            Student student1 = new Student();
            student1.Name = "subroto";
            student1.Email = "s@mail.com";
            student1.Address = "Dhaka";

            Student student2 = new Student();
            student2.Name = "suuuu";
            student2.Email = "h@mail.com";
            student2.Address = "Dhaka";

            Student student3 = new Student();
            student3.Name = "suvo";
            student3.Email = "u@mail.com";
            student3.Address = "mirpur";

            List<Student> students = new List<Student>();
            students.Add(student3);
            students.Add(student2);
            students.Add(student1);

            //  ViewBag.students = students;
            // ViewBag.Student = student;
            return View(students);
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
                department.Id =Convert.ToInt32(dataReader["Id"]);
                department.ShortName = dataReader["ShortName"].ToString();
                departments.Add(department);
            }
            sqlConnection.Close();
            dataReader.Close();
            return departments;
        }
        public string Hello(Student student)
        {
            return "This is hello function " + student.Name + " " + student.Address + " " + student.Email;
        }
        public ActionResult SaveStudent()
        {
            ViewBag.Departments = GetDepartment();
            ViewBag.Students = GetAllStudent();
            return View();
        }
        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            string connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDb;User Id=sa;Password=Bina;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "Insert into Student (Name,Email,Address,DepartmentId) Values('" + student.Name + "','" + student.Email + "','" + student.Address + "','"+student.DepartmentId+"')";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowCount = command.ExecuteNonQuery();
            sqlConnection.Close();
            string message;
            if (rowCount > 0)
            {
                message="Save successfully";
            }
            else
            {
               message= "Save Failed";
            }
            ViewBag.Message = message;
            ViewBag.Departments = GetDepartment();
            ViewBag.Students = GetAllStudent();
            return View();
        }
        public List<Student> GetAllStudent()
        {
            string connectionString = "Server=DESKTOP-HD3BUG1;Database=UniversityDb;User Id=sa;Password=Bina;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = @"select Student.Name,Student.Email,Student.Address,Department.Name as DeptName from Student inner join Department
                           on Student.DepartmentId = Department.Id";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader= command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (dataReader.Read())
            {
                Student student = new Student();
                student.Address = dataReader["Address"].ToString();
                student.DepartmentName=dataReader["DeptName"].ToString();
                student.Email = dataReader["Email"].ToString();
                student.Name = dataReader["Name"].ToString();
                students.Add(student);
            }
            sqlConnection.Close();
            dataReader.Close();
            return students;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
