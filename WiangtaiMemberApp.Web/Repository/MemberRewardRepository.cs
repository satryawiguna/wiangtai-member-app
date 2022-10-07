using System;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.Execution;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Response.Functions;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class MemberRewardRepository : BaseRepository<MemberReward>, IMemberRewardRepository
{
    public MemberRewardRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public decimal GetTotalPoints(Guid memberId, Guid? productId)
    {
        var rewardFundIds = from temp in _context.GetRedemptionAllowedFund(productId) select temp;

        var queryBuilder = from query in _context.MemberReward
                           where query.RewardType == (byte)Commons.Common.RewardType.Point
                           where (query.ExpiryDate == null ? DateTime.Now : query.ExpiryDate.Value) > DateTime.Now
                           where query.MemberID == memberId
                           where rewardFundIds.Count(s => s.RewardFundId == query.RewardFundID) > 0
                           select query.BalanceValue;


        return queryBuilder.FirstOrDefault() == null ? (decimal) 0 : (decimal) queryBuilder.Sum(p => p.Value);
    }

    public decimal GetTotalRebate(Guid memberId, Guid? productId)
    {
        var rewardFundIds = from temp in _context.GetRedemptionAllowedFund(productId) select temp;

        var queryBuilder = from query in _context.MemberReward
                           where query.RewardType == (byte)Commons.Common.RewardType.Rebate
                           where (query.ExpiryDate == null ? DateTime.Now : query.ExpiryDate.Value) > DateTime.Now
                           where query.MemberID == memberId
                           where rewardFundIds.Count(s => s.RewardFundId == query.RewardFundID) > 0
                           select query.BalanceValue;

        return queryBuilder.FirstOrDefault() == null ? (decimal)0 : (decimal)queryBuilder.Sum(p => p.Value);
    }
}
