using System;
using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class MemberTypeRepository : BaseRepository<MemberType>, IMemberTypeRepository
{
    public MemberTypeRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public MemberType? GetById(Guid id)
    {
        return _entities.Find(id);
    }

    public IEnumerable<MemberType> GetAll<TOrderBy>(Expression<Func<MemberType, TOrderBy>> orderBy)
    {
        return _entities.OrderBy(orderBy).ToList();
    }
}
