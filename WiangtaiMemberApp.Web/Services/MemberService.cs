using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Repository;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _memberRepository;

    private readonly IMemberTypeRepository _memberTypeRepository;

    private readonly IMapper _mapper;

    public MemberService(IMemberRepository memberRepository,
        IMemberTypeRepository memberTypeRepository,
        IMapper mapper)
    {
        _memberRepository = memberRepository;
        _memberTypeRepository = memberTypeRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Member>> GetAllMembers()
    {
        return _memberRepository.GetAll();
    }

    public async Task<SearchResponseDto<MemberDto>> GetSearchMembers(SearchRequestDto searchRequest, int? intNoType, int? memberType)
    {
        return _memberRepository.GetSearch(searchRequest, intNoType, memberType);
    }

    public async Task<PageSearchResponseDto<MemberDto>> GetPageSearchMembers(PageSearchRequestDto pageSearchRequest, int? intNoType, int? memberType)
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



    public async Task<IEnumerable<MemberType>> GetAllMemberTypes()
    {
        return _memberTypeRepository.GetAll();
    }

    public async Task<IEnumerable<MemberType>> GetAllMemberTypesByFilter(Expression<Func<MemberType, bool>> filter)
    {
        return _memberTypeRepository.GetSelectListByFilter(filter);
    }
}

