using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private ToDoListContext db = new ToDoListContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }

        //public IActionResult TaskCategoryViewModel()
        //{
        //    List<object> myModel = new List<object>();
        //    myModel.Add(db.Categories.ToList());
        //    myModel.Add(db.Items.ToList());
        //    return View(myModel); 
        //}
    }
}
