using System;
using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Commons.Mappers.ValueResolver;

public class TotalPointsBalanceResolver : IValueResolver<Member, MemberDto, decimal>
{
    private readonly IMemberRewardRepository _memberRewardRepository;

    public TotalPointsBalanceResolver(IMemberRewardRepository memberRewardRepository)
    {
        _memberRewardRepository = memberRewardRepository;
    }

    public decimal Resolve(Member source, MemberDto destination, decimal destMember, ResolutionContext context)
    {
        return _memberRewardRepository.GetTotalPoints(source.MemberID, null);
    }
}