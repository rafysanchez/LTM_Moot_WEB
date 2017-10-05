using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    // rafael sanchez portal tel 949678051
    // dava para incrementar mas quem faz isto na mão faz qualquer coisa


    public class Produtos
    {
        [Key]
        public int ID { get; set; }
        public string Produto { get; set; }
        public string Fabricante { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public Nullable<int> Estoque { get; set; }


    }



    public  class Employees
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Salary { get; set; }
    }

    public  class EmployeeDBEntities : DbContext
    {
        public EmployeeDBEntities()
            : base("name=EmployeeDBEntities")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
    }

}