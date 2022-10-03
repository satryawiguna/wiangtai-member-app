using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IMemberService
{
    Task<IEnumerable<Member>> GetAllMembers();

    Task<SearchResponseDto<Member>> GetSearchMembers(SearchRequestDto searchRequest, int? intNoType, int? memberType);

    Task<PageSearchResponseDto<Member>> GetPageSearchMembers(PageSearchRequestDto pageSearchRequest, int? intNoType, int? memberType);

    Task<Member> GetMemberByID(string memberId);

    Task<(bool, Member)> CreateMember(MemberRequestDto request);

    Task<(bool, Member)> UpdateMember(MemberRequestDto request);

    Task<bool> DeleteMember(string memberId);


    Task<IEnumerable<MemberType>> GetAllMemberTypes();

    Task<IEnumerable<MemberType>> GetAllMemberTypesByFilter(Expression<Func<MemberType, bool>> filter);
}

