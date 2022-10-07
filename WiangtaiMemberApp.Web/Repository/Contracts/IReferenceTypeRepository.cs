using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IReferenceTypeRepository : IBaseRepository<ReferenceType>
{
    IEnumerable<ReferenceType> GetAll<TOrderBy>(Expression<Func<ReferenceType, bool>> filter, Expression<Func<ReferenceType, TOrderBy>> orderBy);
}
