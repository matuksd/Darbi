using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Produkti_MVC_Task2.Models
{
    public class Produkti
    {
        public int Id { get; set; }
        public string Kods { get; set; }
        public string Nosaukums { get; set; }
        public int Skaits { get; set; }
        public double Cena { get; set; }
        public string Datums { get; set; }
        public string Attels { get; set; }
    }
}