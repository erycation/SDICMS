using AutoMapper;
using MSChildNotification.NotificationDomain.Model;
using MSChildNotification.NotificationDomain.Model.Dtos;

namespace MSChildNotification.Extentions
{
    public class MappersExtentions : Profile
    {
        public MappersExtentions()
        {          

            CreateMap<ChildInformation, ChildInformationDto>();
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
        }
    }
}

