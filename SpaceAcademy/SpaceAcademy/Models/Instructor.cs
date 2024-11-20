using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceAcademy.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Experience { get; set; }
        public string Image { get; set; }

        public Instructor(int id,string n, int age, string exp,string img)
        {
            ID = id;
            Name = n;
            Age = age;
            Experience = exp;
            Image = img;
        }
    }
}