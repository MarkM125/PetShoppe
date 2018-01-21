using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShoppe.Models
{
    public class PetsModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public PetsModel(string name, int age, string species)
        {
            this.Name = name;
            this.Age = age;
            this.Species = species;
        }
    }
}