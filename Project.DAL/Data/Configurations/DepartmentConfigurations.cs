using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.DAL.Models;

namespace Project.DAL.Data.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder) 
        {
            builder.Property(d => d.Id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("varchar(20)");
            builder.Property(d => d.Code).HasColumnType("varchar(20)");
            builder.Property(d => d.CreatedOn).HasDefaultValueSql("GETDATE()"); // only work on insert لو في قيمة بتحطها مفيش بتحط القيمة والقيمة دي مش بتتغير  
            builder.Property(d => d.LastModifiedOn).HasComputedColumnSql("GETDATE()"); //  قيمتها بتتغير بعد ال انسيرت مع كل ابتديت القيمة دي بتتغير عكس اللي فوقيها مبتتغيرش 
        }
    }
}
