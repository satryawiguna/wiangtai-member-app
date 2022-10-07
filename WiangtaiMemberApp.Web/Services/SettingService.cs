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
    private readonly ILogger<SettingService> _logger;
    private readonly IMapper _mapper;
    private readonly ISettingRepository _settingRepository;

    public SettingService(ILogger<SettingService> logger,
        IMapper mapper,
        ISettingRepository settingRepository)
    {
        _logger = logger;
        _mapper = mapper;
        _settingRepository = settingRepository;
    }

    public Setting? GetSettingByFilter(Expression<Func<Setting, bool>> filter)
    {
        return _settingRepository.GetByFilter(filter);
    }
}
