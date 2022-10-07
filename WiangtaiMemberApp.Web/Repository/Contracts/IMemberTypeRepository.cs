using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberTypeRepository : IBaseRepository<MemberType>
{
    MemberType? GetById(Guid id);

    IEnumerable<MemberType> GetAll<TOrderBy>(Expression<Func<MemberType, TOrderBy>> orderBy);
}
