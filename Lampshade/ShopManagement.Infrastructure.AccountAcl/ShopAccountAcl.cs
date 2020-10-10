using System;
using AccountManagement.Application.Contracts.Account;
using ShopManagement.Domain.Services;

namespace ShopManagement.Infrastructure.AccountAcl
{
    public class ShopAccountAcl : IShopAccountAcl
    {
        private readonly IAccountApplication _accountApplication;

        public ShopAccountAcl(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public (string name, string mobile) GetAccountBy(long id)
        {
            var account = _accountApplication.GetAccountBy(id);
            return (account.Fullname, account.Mobile);
        }
    }
}