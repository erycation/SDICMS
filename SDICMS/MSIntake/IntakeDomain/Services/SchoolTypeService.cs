using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class SchoolTypeService : ISchoolTypeService
    {
        private readonly IMapper _mapper;
        private readonly ISchoolTypeRepository _schoolTypeRepository;

        public SchoolTypeService(IMapper mapper,
                                ISchoolTypeRepository schoolTypeRepository)
        {
            _mapper = mapper;
            _schoolTypeRepository = schoolTypeRepository;
        }

        public async Task<SchoolTypeDto> CreateSchoolType(SchoolTypeDto schoolTypeDto)
        {
            var requestSchoolType = new SchoolType
            {
                Description = schoolTypeDto.Description,
                Source = schoolTypeDto.Source,
                Definition = schoolTypeDto.Definition
            };

            var responseSchoolType = await _schoolTypeRepository.CreateSchoolType(requestSchoolType);
            if (responseSchoolType == null)
                throw new AppException($"Error creating schoolType.");
            return _mapper.Map<SchoolTypeDto>(responseSchoolType);
        }

        public async Task<List<SchoolTypeDto>> GetAllSchoolType()
        {
            var responseSchoolTypes = await _schoolTypeRepository.GetAllSchoolType();
            return _mapper.Map<List<SchoolTypeDto>>(responseSchoolTypes);
        }

        public async Task<SchoolTypeDto> GetSchoolTypeById(int schoolTypeId)
        {
            var responseSchoolType = await _schoolTypeRepository.GetSchoolTypeById(schoolTypeId);
            return _mapper.Map<SchoolTypeDto>(responseSchoolType);
        }

        public async Task<SchoolTypeDto> UpdateSchoolType(SchoolTypeDto schoolTypeDto)
        {
            var responseSchoolType = await _schoolTypeRepository.GetSchoolTypeById(schoolTypeDto.School_Type_Id);
            if (responseSchoolType == null)
                throw new AppException($"SchoolType {responseSchoolType.Description} not found.");
            responseSchoolType.Description = schoolTypeDto.Description;
            var responseUpdatedSchoolType = await _schoolTypeRepository.UpdateSchoolType(responseSchoolType);
            return _mapper.Map<SchoolTypeDto>(responseUpdatedSchoolType);
        }
    }
}
