using System;
using System.Reflection;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Web.Repository;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _memberRepository;

    public MemberService(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    public async Task<IEnumerable<Member>> GetAllMembers()
    {
        return _memberRepository.GetAll();
    }

    public async Task<SearchResponseDto<Member>> GetSearchMembers(SearchRequestDto searchRequest, int intNoType, int memberType)
    {
        return _memberRepository.GetSearch(searchRequest, intNoType, memberType);
    }

    public async Task<PageSearchResponseDto<Member>> GetPageSearchMembers(PageSearchRequestDto pageSearchRequest, int intNoType, int memberType)
    {
        return _memberRepository.GetPageSearch(pageSearchRequest, intNoType, memberType);
    }

    public Task<(bool, Member)> CreateMember(MemberRequestDto request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteMember(string memberId)
    {
        throw new NotImplementedException();
    }

    public Task<Member> GetMemberByID(string memberId)
    {
        throw new NotImplementedException();
    }

    public Task<(bool, Member)> UpdateMember(MemberRequestDto request)
    {
        throw new NotImplementedException();
    }
}

