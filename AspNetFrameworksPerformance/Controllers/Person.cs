using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetFrameworksPerformance.Controllers
{
    public class Person
    {
        public Person()
        {
            Id = 10;
            Name = "Rick";
            Entered = new DateTime(2013,1,1);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Entered { get; set; }
    }
}
