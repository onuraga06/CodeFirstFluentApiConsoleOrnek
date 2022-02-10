using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApi.Entities.CodeFirstMapping
{
   public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(x => x.CustomerID);
            this.Property(x => x.CustomerID).IsRequired()
                .HasMaxLength(5);
            this.Property(x => x.CompanyName).IsRequired().HasMaxLength(40);
            this.Property(x => x.City).HasMaxLength(15);
            this.Property(x => x.ContactName).HasMaxLength(30);
            this.Property(x => x.Country).HasMaxLength(15);

            this.ToTable("Customers");//Bu Sınıfı verıtabanındakı Customers ıle  ılıskılendır.
            //this.Property(x => x.Country).HasColumnName("County");// Colonu  ıle ılıskendırme
        }
    }
}
