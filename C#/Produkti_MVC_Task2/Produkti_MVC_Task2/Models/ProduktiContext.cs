using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Produkti_MVC_Task2.Models
{
    public class ProduktiContext : DbContext
    {
        public DbSet<Produkti> Produkti { get; set; }
    }
}