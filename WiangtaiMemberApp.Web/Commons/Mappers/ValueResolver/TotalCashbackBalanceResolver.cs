

using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Commons.Mappers.ValueResolver;

public class TotalCashbackBalanceResolver : IValueResolver<Member, MemberDto, decimal>
{
    private readonly IMemberRewardRepository _memberRewardRepository;

    public TotalCashbackBalanceResolver(IMemberRewardRepository memberRewardRepository)
    {
        _memberRewardRepository = memberRewardRepository;
    }

    public decimal Resolve(Member source, MemberDto destination, decimal destMember, AutoMapper.ResolutionContext context)
    {
        return _memberRewardRepository.GetTotalRebate(source.MemberID, null);
    }
}

