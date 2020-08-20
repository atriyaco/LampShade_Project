using _0_Framework.Application;
using System.Collections.Generic;

namespace CommentManagement.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        OperationResult Add(AddComment command);
        OperationResult Confirm(long id);
        OperationResult Cancel(long id);
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
