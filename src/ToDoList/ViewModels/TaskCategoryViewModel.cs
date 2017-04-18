using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.ViewModels
{
    public class TaskCategoryViewModel
    {
        public IEnumerable<ToDoList.Models.Item> Items { get; set; }
        public IEnumerable<ToDoList.Models.Category> Categories { get; set; }
    }
}
