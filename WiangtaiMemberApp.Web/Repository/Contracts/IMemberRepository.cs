using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberRepository : IBaseRepository<Member>
{
    SearchResponseDto<MemberDto> GetSearch(SearchRequestDto searchRequest, string? memberType, int referenceType);

    PageSearchResponseDto<MemberDto> GetPageSearch(PageSearchRequestDto pageSearchRequest, string? memberType, int referenceType);
}
