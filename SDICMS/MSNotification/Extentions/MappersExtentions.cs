using AutoMapper;
using MSChildNotification.NotificationDomain.Model;
using MSChildNotification.NotificationDomain.Model.Dtos;

namespace MSChildNotification.Extentions
{
    public class MappersExtentions : Profile
    {
        public MappersExtentions()
        {

            CreateMap<ChildInformation, ChildInformationDto>()
                .ForMember(s => s.GenderDto, r => r.MapFrom(ur => ur.Gender))
                .ForMember(s => s.IdentityTypeDto, r => r.MapFrom(ur => ur.IdentityType))
                .ForMember(s => s.LanguageDto, r => r.MapFrom(ur => ur.Language))
                .ForMember(s => s.RaceDto, r => r.MapFrom(ur => ur.Race))
                .ForMember(s => s.CountryDto, r => r.MapFrom(ur => ur.Country));
            CreateMap<Country, CountryDto>();
            CreateMap<District, DistrictDto>();
            CreateMap<Gender, GenderDto>();
            CreateMap<IdentityType, IdentityTypeDto>();
            CreateMap<Language, LanguageDto>();
            CreateMap<NotificationCase, NotificationCaseDto>();
            CreateMap<Notification, NotificationDto>();
            CreateMap<PoliceStation, PoliceStationDto>();
            CreateMap<Province, ProvinceDto>();
            CreateMap<Race, RaceDto>();
            CreateMap<OffenseType, OffenseTypeDto>();
            CreateMap<CaseInformation, CaseInformationDto>();

        }
    }
}

