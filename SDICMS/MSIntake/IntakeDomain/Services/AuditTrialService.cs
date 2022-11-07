using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class AuditTrialService : IAuditTrialService
    {
        private readonly IMapper _mapper;
        private readonly IAuditTrialRepository _auditTrialRepository;

        public AuditTrialService(IMapper mapper,
                                  IAuditTrialRepository auditTrialRepository)
        {
            _mapper = mapper;
            _auditTrialRepository = auditTrialRepository;
        }

        public Task<AuditTrialDto> CreateAuditTrial(AuditTrialDto auditTrialDto)
        {
            throw new NotImplementedException();
        }

        public Task<AuditTrialDto> GetAuditTrialById(int auditTrailId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuditTrialDto>> GetAuditTrials()
        {
            throw new NotImplementedException();
        }

        //public async Task<AddressTypeDto> GetAddressTypeById(int addressTypeId)
        //{
        //    var responseAddressType = await _addressTypeRepository.GetAddressTypeById(addressTypeId);
        //    return _mapper.Map<AddressTypeDto>(responseAddressType);
        //}

        //public async Task<List<AddressTypeDto>> GetAddressTypes()
        //{
        //    var responseAddressType = await _addressTypeRepository.GetAddressTypes();
        //    return _mapper.Map<List<AddressTypeDto>>(responseAddressType);
        //}
    }
}