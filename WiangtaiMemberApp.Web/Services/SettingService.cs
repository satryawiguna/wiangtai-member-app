using System;
using System.Linq.Expressions;
using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class SettingService : ISettingService
{
    private readonly ISettingRepository _settingRepository;

    private readonly IMapper _mapper;

    public SettingService(ISettingRepository settingRepository,
        IMapper mapper)
    {
        _settingRepository = settingRepository;
        _mapper = mapper;
    }

    public string GetSettingByFilter(Expression<Func<Setting, bool>> filter)
    {
        return _settingRepository.GetSettingEncryptCardNumberByFilter(filter);
    }
}
