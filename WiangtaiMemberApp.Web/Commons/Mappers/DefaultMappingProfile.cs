using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Model.Response.Member;
using WiangtaiMemberApp.Web.Commons.Mappers.ValueResolver;
using WiangtaiMemberApp.Web.Models.Member;

namespace WiangtaiMemberApp.Web.Commons.Mappers;

public class DefaultMappingProfile : Profile
{
    public DefaultMappingProfile()
    {
        CreateMap<Member, MemberDto>()
            .ForMember(d => d.EmailConsent, opt => opt.MapFrom(s => s.Notification))
            .ForMember(d => d.MobileConsent, opt => opt.MapFrom(s => s.Notification))
            .ForMember(d => d.MemberType, opt => opt.MapFrom(s => s.MemberType.MemberTypeName))
            .ForMember(d => d.MemberCard, opt => opt.MapFrom(s => s.Memberships.Where(m => m.EndDate > DateTime.Now).Select(m => m.CardNumber)))
            .ForMember(d => d.Race, opt => opt.MapFrom(s => s.RaceType.RaceName))
            .ForMember(d => d.Religion, opt => opt.MapFrom(s => s.Religion.ReligionName))
            .ForMember(d => d.SalaryRange, opt => opt.MapFrom(s => s.SalaryRange))
            .ForMember(d => d.MemberSince, opt => opt.MapFrom(s => ((DateTime)s.MemberSince).ToString("MM/dd/yyyy")))
            .ForMember(d => d.TotalPointBalance, opt => opt.MapFrom<TotalPointsBalanceResolver>())
            .ForMember(d => d.TotalCashBack, opt => opt.MapFrom<TotalCashbackBalanceResolver>());

        CreateMap<CreateMemberVM, SubmitMemberRequestDto>();
        CreateMap<SubmitMemberRequestDto, Member>();
    }
}