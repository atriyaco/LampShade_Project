using _0_Framework.Domain;
using DiscountManagement.Application.Contract.CustomerDiscount;
using System.Collections.Generic;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public interface ICustomerDiscountRepository : IRepository<long, CustomerDiscount>
    {
        EditCustoemrDiscount GetDetails(long id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}
