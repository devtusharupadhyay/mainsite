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

        public bool IsEmailExist { get; set; } = true;

        private async void LoginUser()
        {
            try
            {
                var response = await _userService.LoginUserAsync(_loginViewModel);

                if (response == null)
                {
                    IsEmailExist = false;
                    return;
                }
                else
                {
                    IsEmailExist = true;
                }

                if (response > 0)
                {
                    _navigationManager.NavigateTo("/mainsite/agenda");
                }
            }
            catch (Exception)
            {

               
            }
            finally
            {
                StateHasChanged();
            }
           
        }

        private void ResetForm()
        {
            IsEmailExist = true;
            StateHasChanged();
        }


    }
}
