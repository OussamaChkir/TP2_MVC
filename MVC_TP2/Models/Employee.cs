using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TP2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required][MaxLength(50,ErrorMessage ="Taille Max 50 cc")]
        public string Name { get; set; }
        public string Departement { get; set; }
        [Range(300,5000,ErrorMessage ="Doit etre entre 300 et 5000")]
        public int salary { get; set; }
    }
}
