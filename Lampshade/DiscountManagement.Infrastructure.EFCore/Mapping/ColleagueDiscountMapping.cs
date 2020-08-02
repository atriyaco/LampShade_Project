using DiscountManagement.Domain.ColleagueDiscountAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiscountManagement.Infrastructure.EFCore.Mapping
{
    public class ColleagueDiscountMapping : IEntityTypeConfiguration<ColleagueDiscount>
    {
        public void Configure(EntityTypeBuilder<ColleagueDiscount> builder)
        {
            builder.ToTable("ColleagueDiscounts");
            builder.HasKey(x => x.Id);
        }
    }
}
