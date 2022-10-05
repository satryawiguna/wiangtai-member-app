using System;
using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface ISettingService
{
    string GetSettingByFilter(Expression<Func<Setting, bool>> filter);
}

