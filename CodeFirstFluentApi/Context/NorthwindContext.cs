using CodeFirstFluentApi.Entities;
using CodeFirstFluentApi.Entities.CodeFirstMapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApi.Context
{
    public class NorthwindContext:DbContext
    {
        //public NorthwindContext():base("Name=NorthwindContext")//Butun Connectionstringler northwıncontexnte gelır
        //{

        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());

        }
    }
}
