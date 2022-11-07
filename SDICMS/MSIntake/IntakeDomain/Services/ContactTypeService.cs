using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class ContactTypeService : IContactTypeService
    {
        private readonly IMapper _mapper;
        private readonly IContactTypeRepository _contactTypeRepository;

        public ContactTypeService(IMapper mapper,
                                  IContactTypeRepository contactTypeRepository)
        {
            _mapper = mapper;
            _contactTypeRepository = contactTypeRepository;
        }

        public async Task<List<ContactTypeDto>> GetContactTypes()
        {
            var responseContactType = await _contactTypeRepository.GetContactTypes();
            return _mapper.Map<List<ContactTypeDto>>(responseContactType);
        }

        public async Task<ContactTypeDto> GetContactTypeById(int contactTypeId)
        {
            var responseContactType = await _contactTypeRepository.GetContactTypeById(contactTypeId);
            return _mapper.Map<ContactTypeDto>(responseContactType);
        }
    }
}