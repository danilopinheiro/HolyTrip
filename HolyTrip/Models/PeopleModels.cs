using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolyTrip.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Occupation { get; set; }

        public int Age { get; set; }
    }

    public class People
    {
        public List<Person> Items { get; set; }
    }
}