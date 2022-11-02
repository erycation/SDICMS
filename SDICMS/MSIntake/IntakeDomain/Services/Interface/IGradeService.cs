using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface IGradeService
    {
        Task<List<GradeDto>> GetAllGrades();
    }
}
