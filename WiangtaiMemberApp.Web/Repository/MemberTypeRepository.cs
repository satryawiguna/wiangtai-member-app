using System;
using System.Linq.Expressions;
using AutoMapper;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class MemberTypeRepository : BaseRepository<MemberType>, IMemberTypeRepository
{
    private readonly IMapper _mapper;

    public MemberTypeRepository(WiangtaiMemberAppDbContext context,
        IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public MemberType GetById(Guid id)
    {
        return _entities.Find(id);
    }

    public IEnumerable<MemberType> GetSelectListByFilter(Expression<Func<MemberType, bool>> filter)
    {
        return _entities.Where(filter).OrderBy(mt => mt.MemberTypeName).ToList();
    }
}
