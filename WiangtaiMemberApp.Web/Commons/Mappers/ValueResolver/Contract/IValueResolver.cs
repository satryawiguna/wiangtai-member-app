using AutoMapper;

namespace WiangtaiMemberApp.Web.Commons.Mappers.ValueResolver.Contract;

public interface IValueResolver<in TSource, in TDestination, TDestMember>
{
    TDestMember Resolve(TSource source, TDestination destination, TDestMember destMember, ResolutionContext context);
}
