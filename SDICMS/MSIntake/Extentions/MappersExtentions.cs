using AutoMapper;
using Common_Objects_V2.Intake.Models;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Model.Response;

namespace MSIntake.Extentions
{
    public class MappersExtentions : Profile
    {
        public MappersExtentions()
        {

            CreateMap<User, UserDto>()
                .ForMember(s => s.UserRoleDtos, r => r.MapFrom(ur => ur.UserRoles));
            CreateMap<User, MobileResponse>();            
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
            CreateMap<Address, AddressDto>()
                 .ForMember(a => a.AddressTypeDto, r => r.MapFrom(at => at.AddressType));
            CreateMap<AddressType, AddressTypeDto>();
            CreateMap<Allergy, AllergyDto>();
            CreateMap<ContactType, ContactTypeDto>();
            CreateMap<Citizenship, CitizenshipDto>();
            CreateMap<AuditTrial, AuditTrialDto>();
            CreateMap<PopulationGroup, PopulationGroupDto>();
            CreateMap<RelationshipType, RelationshipTypeDto>();
            CreateMap<IncomeRange, IncomeRangeDto>();
            CreateMap<Disability, DisabilityDto>();
            CreateMap<DisabilityType, DisabilityTypeDto>()
               .ForMember(d => d.DisabilityDto, r => r.MapFrom(ur => ur.Disability));
            CreateMap<Decease, DeceaseDto>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<LinkedDevice, LinkedDeviceDto>()
                .ForMember(s => s.UserDto, r => r.MapFrom(ur => ur.User));
            CreateMap<ProbationOfficer, ProbationOfficerDto>();

        }
    }
}
