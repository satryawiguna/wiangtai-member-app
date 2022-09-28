using System;
using System.Data.Entity;
using System.Linq.Expressions;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class SecurityUserRepository : BaseRepository<SecurityUser>, ISecurityUserRepository
{
    public SecurityUserRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public async Task<SecurityUser?> GetByFilterIncludeRole(Expression<Func<SecurityUser, bool>> filter)
    {
        return _context.SecurityUser
            .Include(sr => sr.SecurityUserRoles.Select(sr => sr.SecurityRole))
            .FirstOrDefault(filter);
    }
}

