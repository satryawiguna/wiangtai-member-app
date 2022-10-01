
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class MemberRepository : BaseRepository<Member>, IMemberRepository
{
    public MemberRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public SearchResponseDto<Member> GetSearch(SearchRequestDto searchRequest, int intNoType, int memberType)
    {
        var members = _context.Member;

        if (searchRequest.keyword != String.Empty)
        {
            members.Where(member => member.FirstName.Contains(searchRequest.keyword) ||
            member.LastName.Contains(searchRequest.keyword) ||
            member.DisplayName.Contains(searchRequest.keyword) ||
            member.MobilePhone.Contains(searchRequest.keyword) ||
            member.intNoType.Equals(searchRequest.keyword) ||
            member.Email.Contains(searchRequest.keyword));
        }

        if (intNoType != 0)
        {
            members.Where(member => member.intNoType.Equals(intNoType));
        }

        if (memberType != 0)
        {
            members.Where(member => member.MemberTypeID.Equals(intNoType));
        }

        return new SearchResponseDto<Member>
        {
            Total = members.Count(),
            Data = members
        };
    }

    public PageSearchResponseDto<Member> GetPageSearch(PageSearchRequestDto pageSearchRequest, int intNoType, int memberType)
    {
        var members = _context.Member;

        if (pageSearchRequest.keyword != String.Empty)
        {
            members.Where(member => member.FirstName.Contains(pageSearchRequest.keyword) ||
            member.LastName.Contains(pageSearchRequest.keyword) ||
            member.DisplayName.Contains(pageSearchRequest.keyword) ||
            member.MobilePhone.Contains(pageSearchRequest.keyword) ||
            member.intNoType.Equals(pageSearchRequest.keyword) ||
            member.Email.Contains(pageSearchRequest.keyword));
        }

        if (intNoType != 0)
        {
            members.Where(member => member.intNoType.Equals(intNoType));
        }

        if (memberType != 0)
        {
            members.Where(member => member.MemberTypeID.Equals(intNoType));
        }

        return new PageSearchResponseDto<Member>
        {
            Total = members.Count(),
            Offset = pageSearchRequest.offset,
            Limit = pageSearchRequest.limit,
            Data = members
        };
    }
}

