

using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Commons.Mappers.ValueResolver;

public class TotalCashbackBalanceResolver : IValueResolver<Member, MemberDto, decimal>
{
    private readonly ILogger<TotalCashbackBalanceResolver> _logger;
    private readonly IMemberRewardRepository _memberRewardRepository;

    public TotalCashbackBalanceResolver(ILogger<TotalCashbackBalanceResolver> logger,
        IMemberRewardRepository memberRewardRepository)
    {
        _logger = logger;
        _memberRewardRepository = memberRewardRepository;
    }

    public decimal Resolve(Member source, MemberDto destination, decimal destMember, AutoMapper.ResolutionContext context)
    {
        return _memberRewardRepository.GetTotalRebate(source.MemberID, null);
    }
}

