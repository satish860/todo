using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_web.Models
{
    public class TodoModel
    {
        
        public int ToDoId { get; set; }

        public string Item { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
