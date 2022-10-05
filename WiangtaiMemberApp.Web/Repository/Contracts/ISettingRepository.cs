using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface ISettingRepository : IBaseRepository<Setting>
{
    string GetSettingEncryptCardNumberByFilter(Expression<Func<Setting, bool>> filter);
}

