using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcRef.Models
{
    //Todos Model
    public class Todo
    {
        public int Id { get; set; }
        //The Chore
        public string Task { get; set; }
        public DateTime dateCreated { get; set; }
        public bool isCompleted { get; set; }
    }
    //Todos Page ViewModel (VM)
    public class TodoIndexVM
    {
        public string Greeting { get; set; }
        public List<Todo> MyChores { get; set; }

    }
}