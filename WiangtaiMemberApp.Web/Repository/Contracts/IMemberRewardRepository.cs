using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IMemberRewardRepository : IBaseRepository<MemberReward>
{
    decimal GetTotalPoints(Guid memberId, Guid? productId);

    decimal GetTotalRebate(Guid memberId, Guid? productId);
}

