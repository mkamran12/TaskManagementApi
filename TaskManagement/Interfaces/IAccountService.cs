using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
