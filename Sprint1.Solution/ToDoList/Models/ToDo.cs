using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public bool IsDone { set; get; }
        public virtual ApplicationUser User { set; get; }
    }
}