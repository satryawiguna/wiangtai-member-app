using AutoMapper;
using SimpleInjector;

namespace WiangtaiMemberApp.Web.Commons.Mappers;

public class MapperProvider
{
    private readonly Container _container;

    public MapperProvider(Container container)
    {
        _container = container;
    }

    public IMapper GetMapper()
    {
        var mapperConfig = new MapperConfiguration(config =>
        {
            config.ConstructServicesUsing(_container.GetInstance);
            config.AddProfile<DefaultMappingProfile>();
        });

        mapperConfig.AssertConfigurationIsValid();

        return new Mapper(mapperConfig, serviceType => _container.GetInstance(serviceType));
    }
}

