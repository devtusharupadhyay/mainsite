using AngWater.ViewModels;

namespace AngWater.Services
{
    public interface IUserService
    {
        Task<int?> LoginUserAsync(LoginViewModel viewModel);
    }
}