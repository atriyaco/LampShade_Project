using _0_Framework.Domain;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using System.Collections.Generic;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
    public interface IColleagueDiscountRepository : IRepository<long, ColleagueDiscount>
    {
        EditColleagueDiscount GetDetails(long id);
        List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel);
    }
}
