using _0_Framework.Application;
using System.Collections.Generic;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public interface ICustomerDiscountApplication
    {
        OperationResult Define(DefineCustomerDiscount command);
        OperationResult Edit(EditCustoemrDiscount command);
        EditCustoemrDiscount GetDetails(long id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}
