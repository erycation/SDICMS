using AutoMapper;
using MSChildNotification.NotificationDomain.Model.Dtos;
using MSChildNotification.NotificationDomain.Service.Interface;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.NotificationDomain.Service
{
    public class OffenseTypeService : IOffenseTypeService
    {

        private readonly IMapper _mapper;
        private readonly IOffenseTypeRepository _offenseTypeRepository;

        public OffenseTypeService(IMapper mapper,
                                  IOffenseTypeRepository offenseTypeRepository)
        {
            _mapper = mapper;
            _offenseTypeRepository = offenseTypeRepository;
        }

        public async Task<OffenseTypeDto> GetOffenseTypeByCode(string offenseCode)
        {
            var responseOffenseCode = await _offenseTypeRepository.GetOffenseTypeByCode(offenseCode);
            return responseOffenseCode == null ? new OffenseTypeDto() : _mapper.Map<OffenseTypeDto>(responseOffenseCode);
        }
    }
}
