using MSIntake.IntakeDomain.Model.Dtos;

namespace MSIntake.IntakeDomain.Services.Interface
{
    public interface ISkinColorService
    {
        Task<List<SkinColorDto>> GetAllSkinColors();
    }
}
