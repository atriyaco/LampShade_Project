using _0_Framework.Domain;
using System;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public class CustomerDiscount : EntityBase
    {
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        //public bool IsActive { get; set; }
        public string Reason { get; private set; }

        public CustomerDiscount(long productId, int discountRate, DateTime startDate, 
            DateTime endDate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
            //IsActive = true;
        }

        public void Edit(long productId, int discountRate, DateTime startDate,
            DateTime endDate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
    }
}
