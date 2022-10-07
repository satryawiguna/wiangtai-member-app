using System.Linq.Expressions;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IMemberService
{
    Task<PageSearchResponseDto<MemberDto>> GetPageSearchMembersAsync(PageSearchRequestDto pageSearchRequest, string? memberType, int referenceType);

    Task<bool> StoreMemberAsync(SubmitMemberRequestDto request);


    IEnumerable<MemberType> GetAllMemberTypes();

    IEnumerable<MemberType> GetAllMemberTypes<TOrderBy>(Expression<Func<MemberType, TOrderBy>> orderBy);


    IEnumerable<ReferenceType> GetAllReferenceTypes<TOrderBy>(Expression<Func<ReferenceType, bool>> filter, Expression<Func<ReferenceType, TOrderBy>> orderBy);

}

