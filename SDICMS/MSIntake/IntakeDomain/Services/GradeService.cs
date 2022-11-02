using AutoMapper;
using Common_Objects_V2.Intake.Repository.Interface;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.IntakeDomain.Services
{
    public class GradeService : IGradeService
    {
        private readonly IMapper _mapper;
        private readonly IGradeRepository _gradeRepository;

        public GradeService(IMapper mapper,
                            IGradeRepository gradeRepository)
        {
            _mapper = mapper;
            _gradeRepository = gradeRepository;
        }

        public async Task<List<GradeDto>> GetAllGrades()
        {
            var responseGrades = await _gradeRepository.GetAllGrades();
            return _mapper.Map<List<GradeDto>>(responseGrades);
        }
    }
}
