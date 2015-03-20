using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcRef.Models
{
    //Todos Page ViewModel (VM)
    public class TodoIndexVM
    {
        public string Greeting { get; set; }
        public List<Todo> MyChores { get; set; }
    }
}