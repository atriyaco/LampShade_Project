using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}
