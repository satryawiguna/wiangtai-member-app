using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts
{
	public interface ISecurityUserRepository : IBaseRepository<SecurityUser>
	{
        Task<SecurityUser?> GetByFilterIncludeRole(Expression<Func<SecurityUser, bool>> filter);
    }
}

