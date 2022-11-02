using AutoMapper;
using Common_Objects_V2.Intake.Models;
using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.Extentions
{
    public class MappersExtentions : Profile
    {
        public MappersExtentions()
        {

            CreateMap<User, UserDto>()
                .ForMember(s => s.UserRoleDtos, r => r.MapFrom(ur => ur.UserRoles));           
            CreateMap<Role, RoleDto>();
            CreateMap<UserRole, UserRoleDto>()
                .ForMember(s => s.RoleDto, r => r.MapFrom(ur => ur.Role));
            CreateMap<Group, GroupDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Province, ProvinceDto>();
            CreateMap<District, DistrictDto>();
            CreateMap<LocalMunicipality, LocalMunicipalityDto>();
            CreateMap<Town, TownDto>();
            CreateMap<Organization, OrganizationDto>();
            CreateMap<MenuAccess, MenuAccessDto>();
            CreateMap<MenuAccessRole, MenuAccessRoleDto>();
            CreateMap<Gender, GenderDto>();
            CreateMap<MaritalStatus, MaritalStatusDto>();
            CreateMap<Race, RaceDto>();
            CreateMap<Religion, ReligionDto>();
            CreateMap<SchoolType, SchoolTypeDto>();
            CreateMap<School, SchoolDto>();
            CreateMap<Grade, GradeDto>();
            CreateMap<SkinColor, SkinColorDto>();

        }
    }
}
