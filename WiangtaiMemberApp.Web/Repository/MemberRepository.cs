using System.Data.Entity;
using AutoMapper;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Commons;
using WiangtaiMemberApp.Web.Commons.Extensions;
using WiangtaiMemberApp.Web.Repository.Contracts;
using Z.EntityFramework.Plus;


namespace WiangtaiMemberApp.Web.Repository;

public class MemberRepository : BaseRepository<Member>, IMemberRepository
{
    private readonly IMapper _mapper;
    private readonly IServiceAgentConfigRepository _serviceAgentConfigRepository;

    public MemberRepository(WiangtaiMemberAppDbContext context,
        IMapper mapper,
        IServiceAgentConfigRepository serviceAgentConfigRepository) : base(context)
    {
        _mapper = mapper;
        _serviceAgentConfigRepository = serviceAgentConfigRepository;
    }

    public SearchResponseDto<MemberDto> GetSearch(SearchRequestDto searchRequestDto, string? userId, string? memberType, int referenceType)
    {
        List<ServiceAgentConfig> serviceAgentConfigs = _serviceAgentConfigRepository.GetListByFilter(sac => sac.UserId == new Guid(userId)).ToList();
        UserMemberTierAccess userMemberTierAccess = Shared.GetUserMemberTierAccessList(serviceAgentConfigs);

        var members = userMemberTierAccess.MemberTypeList.Count > 0 ? _entities.Where(member => userMemberTierAccess.MemberTypeList.Contains(member.MemberTypeID.Value)) : _entities;

        if (!String.IsNullOrWhiteSpace(searchRequestDto.keyword))
        {
            members = members.Where(member => member.FirstName.Contains(searchRequestDto.keyword) ||
                member.LastName.Contains(searchRequestDto.keyword) ||
                member.DisplayName.Contains(searchRequestDto.keyword) ||
                member.MobilePhone.Contains(searchRequestDto.keyword) ||
                member.Email.Contains(searchRequestDto.keyword));
        }

        bool orderAsc = searchRequestDto.orderDirection == "ASC";

        switch (searchRequestDto.orderColumn)
        {
            case "FirstName":
                members = members.OrderByDirection(item => item.FirstName, orderAsc);
                break;

            case "LastName":
                members = members.OrderByDirection(item => item.LastName, orderAsc);
                break;

            case "CreatedDate":
            default:
                members = members.OrderByDirection(item => item.CreatedDate, orderAsc);
                break;
        }

        if (!String.IsNullOrEmpty(memberType))
        {
            members.Where(member => member.MemberTypeID.Equals(memberType));
        }

        if (referenceType != 0)
        {
            members.Where(member => member.intNoType == referenceType);
        }

        var data = members.ToList();

        return new SearchResponseDto<MemberDto>
        {
            Total = members.Count(),
            Data = _mapper.Map<IEnumerable<Member>, IEnumerable<MemberDto>>(data)
        };
    }

    public PageSearchResponseDto<MemberDto> GetPageSearch(PageSearchRequestDto pageSearchRequest, string? userId, string? memberType, int referenceType)
    {
        List<ServiceAgentConfig> serviceAgentConfigs = _serviceAgentConfigRepository.GetListByFilter(sac => sac.UserId == new Guid(userId)).ToList();
        UserMemberTierAccess userMemberTierAccess = Shared.GetUserMemberTierAccessList(serviceAgentConfigs);

        var members = userMemberTierAccess.MemberTypeList.Count > 0 ? _entities.Where(member => userMemberTierAccess.MemberTypeList.Contains(member.MemberTypeID.Value)) : _entities;

        if (!String.IsNullOrWhiteSpace(pageSearchRequest.keyword))
        {
            members = members.Where(member => member.FirstName.Contains(pageSearchRequest.keyword) ||
                member.LastName.Contains(pageSearchRequest.keyword) ||
                member.DisplayName.Contains(pageSearchRequest.keyword) ||
                member.MobilePhone.Contains(pageSearchRequest.keyword) ||
                member.Email.Contains(pageSearchRequest.keyword));
        }
            

        bool orderAsc = pageSearchRequest.orderDirection == "ASC";

        switch (pageSearchRequest.orderColumn)
        {
            case "FirstName":
                members = members.OrderByDirection(item => item.FirstName, orderAsc);
                break;

            case "LastName":
                members = members.OrderByDirection(item => item.LastName, orderAsc);
                break;

            case "CreatedDate":
            default:
                members = members.OrderByDirection(item => item.CreatedDate, orderAsc);
                break;
        }

        if (!String.IsNullOrEmpty(memberType))
        {
            members.Where(member => member.MemberTypeID.Equals(memberType));
        }

        if (referenceType != 0)
        {
            members.Where(member => member.intNoType == referenceType);
        }

        var data = members.Skip(pageSearchRequest.offset)
            .Take(pageSearchRequest.limit)
            .ToList();

        return new PageSearchResponseDto<MemberDto>
        {
            Total = members.Count(),
            Offset = pageSearchRequest.offset,
            Limit = pageSearchRequest.limit,
            Data = _mapper.Map<IEnumerable<Member>, IEnumerable<MemberDto>>(data)
        };

    }


    public Member Insert(Member entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        _entities.Add(entity);

        _context.SaveChanges();

        return entity;
    }

    public MemberDto GetById(Guid id)
    {
        var member = _entities.Find(id);

        return _mapper.Map<Member, MemberDto>(member);
    }

}