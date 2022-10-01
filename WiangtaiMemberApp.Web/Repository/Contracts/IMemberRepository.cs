using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Response;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberRepository : IBaseRepository<Member>
{
    SearchResponseDto<Member> GetSearch(SearchRequestDto searchRequest, int intNoType, int memberType);

    PageSearchResponseDto<Member> GetPageSearch(PageSearchRequestDto pageSearchRequest, int intNoType, int memberType);
}
