using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo_web.Models;

namespace Todo_web.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            List<TodoModel> todoModels = new List<TodoModel>
            {
                new TodoModel{ToDoId=1,Item="Hello World",DateAdded=DateTime.Now},
                new TodoModel{ToDoId=2,Item="Something says me that we have a lot to do in this world",DateAdded=DateTime.Now}
            };
            return View(todoModels);
        }
    }
}
