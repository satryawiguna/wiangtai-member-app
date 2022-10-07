using System.Linq.Expressions;
using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class MemberService : IMemberService
{
    private readonly ILogger<MemberService> _logger;
    private readonly IMapper _mapper;
    private readonly IMemberRepository _memberRepository;
    private readonly IMemberTypeRepository _memberTypeRepository;
    private readonly IReferenceTypeRepository _referenceTypeRepository;

    public MemberService(ILogger<MemberService> logger,
        IMapper mapper,
        IMemberRepository memberRepository,
        IMemberTypeRepository memberTypeRepository,
        IReferenceTypeRepository referenceTypeRepository)
    {
        _logger = logger;
        _mapper = mapper;
        _memberRepository = memberRepository;
        _memberTypeRepository = memberTypeRepository;
        _referenceTypeRepository = referenceTypeRepository;
    }

    public async Task<PageSearchResponseDto<MemberDto>> GetPageSearchMembersAsync(PageSearchRequestDto pageSearchRequest, string? memberType, int referenceType)
    {
        return _memberRepository.GetPageSearch(pageSearchRequest, memberType, referenceType);
    }

    public async Task<bool> StoreMemberAsync(SubmitMemberRequestDto request)
    {
        Member entity = _mapper.Map<Member>(request);

        _memberRepository.Insert(entity);

        return true;
    }



    public IEnumerable<MemberType> GetAllMemberTypes()
    {
        return _memberTypeRepository.GetAll();
    }

    public IEnumerable<MemberType> GetAllMemberTypes<TOrderBy>(Expression<Func<MemberType, TOrderBy>> orderBy)
    {
        return _memberTypeRepository.GetAll(orderBy);
    }



    public IEnumerable<ReferenceType> GetAllReferenceTypes<TOrderBy>(Expression<Func<ReferenceType, bool>> filter, Expression<Func<ReferenceType, TOrderBy>> orderBy)
    {
        return _referenceTypeRepository.GetAll(filter, orderBy);
    }
}

