using AngWater.Services;
using AngWater.ViewModels;
using Microsoft.AspNetCore.Components;

namespace AngWater.Pages
{
    public partial class Index :ComponentBase
    {
        private LoginViewModel _loginViewModel { get; set; } = new LoginViewModel();

        [Inject]
        private IUserService _userService { get; set; }

        [Inject]
        private NavigationManager _navigationManager { get; set; }

        private async void LoginUser()
        {
            var response = await _userService.LoginUserAsync(_loginViewModel);

            if (response > 0)
            {
                _navigationManager.NavigateTo("/mainsite/agenda");
            }
        }


    }
}
