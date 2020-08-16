using BlogManagement.Application.Contracts.ArticleCategory;
using System.Collections.Generic;

namespace BlogManagement.Application.Contracts.Article
{
    public class ArticleSearchModel
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }
    }
}
