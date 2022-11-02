using AutoMapper;
using Common_Objects_V2.Intake.Models;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;
using MSIntake.Shared.Helpers;

namespace MSIntake.IntakeDomain.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IMapper _mapper;
        private readonly ISchoolRepository _schoolRepository;

        public SchoolService(IMapper mapper,
                                ISchoolRepository schoolRepository)
        {
            _mapper = mapper;
            _schoolRepository = schoolRepository;
        }

        public async Task<SchoolDto> CreateSchool(SchoolDto schoolDto)
        {
            var requestSchool = new School
            {
                School_Type_Id = schoolDto.School_Type_Id,
                School_Name = schoolDto.School_Name,
                Contact_Person = schoolDto.Contact_Person,
                Telephone_Number = schoolDto.Telephone_Number,
                Cellphone_Number = schoolDto.Cellphone_Number,
                Fax_Number = schoolDto.Fax_Number,
                Email_Address = schoolDto.Email_Address,
                Created_By = schoolDto.Created_By,
                Modified_By = schoolDto.Modified_By,
                NatEmis = schoolDto.NatEmis
            };

            var responseSchool = await _schoolRepository.CreateSchool(requestSchool);
            if (responseSchool == null)
                throw new AppException($"Error creating school.");
            return _mapper.Map<SchoolDto>(responseSchool);
        }

        public async Task<List<SchoolDto>> GetAllSchoolByType(int schoolTypeId)
        {
            var responseSchool = await _schoolRepository.GetAllSchoolByType(schoolTypeId);
            return _mapper.Map<List<SchoolDto>>(responseSchool);
        }

        public async Task<SchoolDto> GetSchoolById(int schoolId)
        {
            var responseSchool = await _schoolRepository.GetSchoolById(schoolId);
            return _mapper.Map<SchoolDto>(responseSchool);
        }

        public async Task<SchoolDto> UpdateSchool(SchoolDto schoolDto)
        {
            var responseSchool = await _schoolRepository.GetSchoolById(schoolDto.School_Id);
            if (responseSchool == null)
                throw new AppException($"School {responseSchool.School_Name} not found.");
            responseSchool.Date_Last_Modified = DateTime.Now; ;
            var responseUpdatedSchool = await _schoolRepository.UpdateSchool(responseSchool);
            return _mapper.Map<SchoolDto>(responseUpdatedSchool);
        }
    }
}