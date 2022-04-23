using AngWater.Models;
using AngWater.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace AngWater.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int?> LoginUserAsync(LoginViewModel viewModel)
        {
            string email = viewModel.EmailAddress.Trim().ToLower();
            
            var user = await _context.Users.Where(x => x.EmailAddress == email)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return null;
            }

            //log entry for the user
            Log log = new()
            {
                CreatedDate = DateTime.Now,
                EmailAddress = email,
                LoggedDate = DateTime.Now,
                Name = viewModel.Name,
                IsActive = true,
                ModifiedDate = DateTime.Now,

            };
            var response = await _context.Logs.AddAsync(log);
            int status = await _context.SaveChangesAsync();

            return status;
        }
    }
}
