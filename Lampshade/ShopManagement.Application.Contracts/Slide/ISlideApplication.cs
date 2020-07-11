using _0_Framework.Application;
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Slide
{
    public interface ISlideApplication
    {
        OperationResult Create(CreateSlide command);
        OperationResult Edit(EditSlide command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditSlide GetDetails(long id);
        List<SlideViewModel> GetList();
    }
}
