using DiscountManagement.Domain.CustomerDiscountAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DiscountManagement.Infrastructure.EFCore.Mapping
{
    public class CustomerDiscountMapping : IEntityTypeConfiguration<CustomerDiscount>
    {
        public void Configure(EntityTypeBuilder<CustomerDiscount> builder)
        {
            builder.ToTable("CustomerDiscounts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Reason).HasMaxLength(500);
        }
    }
}
