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

    public List<MemberType> GetSelectListByFilter(Expression<Func<MemberType, bool>> filter)
    {
        return _entities.Where(filter).OrderBy(mt => mt.MemberTypeName).ToList();
    }
}
