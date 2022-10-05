using System;
using System.Linq;
using System.Linq.Expressions;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class SettingRepository : BaseRepository<Setting>, ISettingRepository
{
    public SettingRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public string GetSettingEncryptCardNumberByFilter(Expression<Func<Setting, bool>> filter)
    {
        return _entities.Where(filter).FirstOrDefault().strValue;
    }
}