using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceAcademy.Models
{
    public class SpaceObj
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }

        public int Id { get; set; }

        public SpaceObj(int id,string n, string desc, string img)
        {
            Id = id;
            Name = n;
            Desc = desc;
            Image = img;
        }
    }
}