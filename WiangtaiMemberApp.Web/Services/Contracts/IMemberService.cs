using System.Linq.Expressions;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IMemberService
{
    Task<PageSearchResponseDto<MemberDto>> GetPageSearchMembersAsync(PageSearchRequestDto pageSearchRequest, string? userId, string? memberType, int referenceType);

    Member StoreMember(CreateMemberRequestDto request);

    Member UpdateMember(UpdateMemberRequestDto request);

    MemberDto ShowMember(Guid memberId);


    IEnumerable<MemberType> GetAllMemberTypes();

    IEnumerable<MemberType> GetAllMemberTypes<TOrderBy>(Expression<Func<MemberType, TOrderBy>> orderBy);


    IEnumerable<ReferenceType> GetAllReferenceTypes<TOrderBy>(Expression<Func<ReferenceType, bool>> filter, Expression<Func<ReferenceType, TOrderBy>> orderBy);


    IEnumerable<RaceType> GetAllRaceTypes();

}

