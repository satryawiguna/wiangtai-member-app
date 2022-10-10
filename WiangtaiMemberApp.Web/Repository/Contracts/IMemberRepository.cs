using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberRepository : IBaseRepository<Member>
{
    SearchResponseDto<MemberDto> GetSearch(SearchRequestDto searchRequest, string? userId, string? memberType, int referenceType);

    PageSearchResponseDto<MemberDto> GetPageSearch(PageSearchRequestDto pageSearchRequest, string? userId, string? memberType, int referenceType);

    Member Insert(Member entity);

    MemberDto GetById(Guid id);
}
