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
    private readonly IRaceTypeRepository _raceTypeRepository;

    public MemberService(ILogger<MemberService> logger,
        IMapper mapper,
        IMemberRepository memberRepository,
        IMemberTypeRepository memberTypeRepository,
        IReferenceTypeRepository referenceTypeRepository,
        IRaceTypeRepository raceTypeRepository)
    {
        _logger = logger;
        _mapper = mapper;
        _memberRepository = memberRepository;
        _memberTypeRepository = memberTypeRepository;
        _referenceTypeRepository = referenceTypeRepository;
        _raceTypeRepository = raceTypeRepository;
    }

    public async Task<PageSearchResponseDto<MemberDto>> GetPageSearchMembersAsync(PageSearchRequestDto pageSearchRequest, string? userId, string? memberType, int referenceType)
    {
        return _memberRepository.GetPageSearch(pageSearchRequest, userId, memberType, referenceType);
    }

    public Member StoreMember(CreateMemberRequestDto request)
    {
        Member entity = _mapper.Map<Member>(request);

        return _memberRepository.Insert(entity);
    }

    public Member UpdateMember(UpdateMemberRequestDto request)
    {
        MemberDto member = _memberRepository.GetById(request.MemberID);

        member.FirstName = request.FirstName;
        member.LastName = request.LastName;
        member.Email = request.Email;
        member.MobilePhone = request.MobilePhone;
        member.EmailConsent = ConvertToNotification(request.EmailConsent.Value, request.MobileConsent.Value);
        member.MobileConsent = ConvertToNotification(request.EmailConsent.Value, request.MobileConsent.Value);
        member.BirthDate = request.BirthDate;
        member.Gender = request.Gender;
        member.Race = request.Race;
        member.MaritalStatus = request.MaritalStatus;
        member.Religion = request.Religion;
        member.SalaryRange = request.SalaryRange;

        var entity = _mapper.Map<Member>(member);

        return _memberRepository.Update(entity);
    }

    public MemberDto ShowMember(Guid memberId)
    {
        return _memberRepository.GetById(memberId);
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



    public IEnumerable<RaceType> GetAllRaceTypes()
    {
        return _raceTypeRepository.GetAll();
    }

    private byte ConvertToNotification(byte emailConsent, byte mobilePhoneConsent)
    {
        if (emailConsent == 0 && mobilePhoneConsent == 0)
        {
            return 0;
        }
        else if (emailConsent == 1 && mobilePhoneConsent == 0)
        {
            return 1;
        }
        else if (emailConsent == 0 && mobilePhoneConsent == 1)
        {   
            return 2;
        }
        else
        {
            return 3;
        }
    }
}

