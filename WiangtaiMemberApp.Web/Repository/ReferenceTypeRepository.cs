using System;
using System.Linq;
using System.Linq.Expressions;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class ReferenceTypeRepository : BaseRepository<ReferenceType>, IReferenceTypeRepository
{
    public ReferenceTypeRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public IEnumerable<ReferenceType> GetAll<TOrderBy>(Expression<Func<ReferenceType, bool>> filter, Expression<Func<ReferenceType, TOrderBy>> orderBy)
    {
        return _entities.Where(filter).OrderBy(orderBy).ToList();
    }
}