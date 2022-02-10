using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApi.Entities.CodeFirstMapping
{
  public  class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(x => x.OrderID);
            this.Property(x => x.CustomerID)
                .IsFixedLength()
                .HasMaxLength(5);//varchar yerıne char olucak ve 5 karekterdn oluscak
            this.ToTable("Orders");

            this.HasOptional(x => x.Customer).WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerID);//Bıre Cok Ilskıyı Kurduk
        }
    }
}
