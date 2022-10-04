using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberTypeRepository : IBaseRepository<MemberType>
{
    MemberType GetById(Guid id);

    IEnumerable<MemberType> GetSelectListByFilter(Expression<Func<MemberType, bool>> filter);
}
