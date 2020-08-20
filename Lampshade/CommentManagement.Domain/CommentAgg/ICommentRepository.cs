using _0_Framework.Domain;
using CommentManagement.Application.Contracts.Comment;
using System.Collections.Generic;

namespace CommentManagement.Domain.CommentAgg
{
    public interface ICommentRepository : IRepository<long, Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
