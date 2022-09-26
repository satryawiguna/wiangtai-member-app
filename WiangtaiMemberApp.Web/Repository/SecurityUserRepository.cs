using System;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class SecurityUserRepository : BaseRepository<SecurityUser>, ISecurityUserRepository
{
    public SecurityUserRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }
}

