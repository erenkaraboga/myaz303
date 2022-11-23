using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace myaz303.Models.Mapping
{
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne(bd => bd.Order).WithOne(bd => bd.OrderDetail).HasForeignKey<OrderDetail>(bd => bd.OrderId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
