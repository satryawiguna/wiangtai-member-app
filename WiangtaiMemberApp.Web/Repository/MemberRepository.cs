
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Commons.Extensions;
using WiangtaiMemberApp.Web.Repository.Contracts;
using Z.EntityFramework.Plus;


namespace WiangtaiMemberApp.Web.Repository;

public class MemberRepository : BaseRepository<Member>, IMemberRepository
{
    private readonly IMapper _mapper;

    public MemberRepository(WiangtaiMemberAppDbContext context,
        IMapper mapper) : base(context)
    {
        _mapper = mapper;
    }

    public SearchResponseDto<MemberDto> GetSearch(SearchRequestDto searchRequestDto, int? intNoType, int? memberType)
    {
        var members = _entities
            .Where(member => String.IsNullOrWhiteSpace(searchRequestDto.keyword) ||
                member.FirstName.Contains(searchRequestDto.keyword) ||
                member.LastName.Contains(searchRequestDto.keyword) ||
                member.DisplayName.Contains(searchRequestDto.keyword) ||
                member.MobilePhone.Contains(searchRequestDto.keyword) ||
                member.intNoType.Equals(searchRequestDto.keyword) ||
                member.Email.Contains(searchRequestDto.keyword));

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

        if (intNoType != 0)
        {
            members.Where(member => member.intNoType.Equals(intNoType));
        }

        if (memberType != 0)
        {
            members.Where(member => member.MemberTypeID.Equals(intNoType));
        }

        var data = members.ToList();

        return new SearchResponseDto<MemberDto>
        {
            Total = members.Count(),
            Data = _mapper.Map<IEnumerable<Member>, IEnumerable<MemberDto>>(data)
        };
    }

    public PageSearchResponseDto<MemberDto> GetPageSearch(PageSearchRequestDto pageSearchRequest, int? intNoType, int? memberType)
    {
        var members = _entities
            .Where(member => String.IsNullOrWhiteSpace(pageSearchRequest.keyword) ||
                member.FirstName.Contains(pageSearchRequest.keyword) ||
                member.LastName.Contains(pageSearchRequest.keyword) ||
                member.DisplayName.Contains(pageSearchRequest.keyword) ||
                member.MobilePhone.Contains(pageSearchRequest.keyword) ||
                member.intNoType.Equals(pageSearchRequest.keyword) ||
                member.Email.Contains(pageSearchRequest.keyword));

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

        if (intNoType != 0)
        {
            members.Where(member => member.intNoType.Equals(intNoType));
        }

        if (memberType != 0)
        {
            members.Where(member => member.MemberTypeID.Equals(intNoType));
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

}

