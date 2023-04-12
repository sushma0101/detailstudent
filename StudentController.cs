using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult StudentDetail()
        {
            StudentModel Sushma = new StudentModel();
            Sushma.Rollno = 1;
            Sushma.Name = "Sushma Sapkota";
            Sushma.Address = "Panauti";
            Sushma.College = "Nist";
            Sushma.Phonenum = 98989;
            return View(Sushma);

        }
        public IActionResult StudentEdit()
        {
            StudentModel Sushma = new StudentModel();
            Sushma.Rollno = 1;
            Sushma.Name = "Sushma Sapkota";
            Sushma.Address = "Panauti";
            Sushma.College = "Nist";
            Sushma.Phonenum = 98989;
            return View(Sushma);

        }
        public IActionResult Students() {
        List<StudentModel>Students = new List<StudentModel>();
            StudentModel Srijit = new StudentModel()
            {
                Rollno = 2,
                Name = "Srijit",
                Address = "Panauti",
                College = "Baylor",
                Phonenum = 989898
            };
            StudentModel Safalta = new StudentModel()
            {
                Rollno = 20,
                Name = "Safalta",
                Address = "Banepa",
                College = "Nist",
                Phonenum = 9898
            };
            StudentModel Shreeti = new StudentModel()
            {
                Rollno = 200,
                Name = "Shreeti",
                Address = "Banepa",
                College = "Nist",
                Phonenum = 98922
            };
            Students.Add(Srijit);
            Students.Add(Safalta);
            Students.Add(Shreeti);
            return View(Students);
        }
    }
}
