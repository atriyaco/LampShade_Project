using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategories();
    }
}
