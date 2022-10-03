using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberTypeRepository : IBaseRepository<MemberType>
{
    public IEnumerable<MemberType> GetSelectListByFilter(Expression<Func<MemberType, bool>> filter);
}
