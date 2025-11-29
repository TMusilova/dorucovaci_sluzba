using DorucovaciSluzba.Application.ViewModels;
using DorucovaciSluzba.Domain.Enums;
using System.Data;

namespace DorucovaciSluzba.Application.Abstraction
{
    public interface IAccountService
    {
        Task<bool> Login(LoginViewModel vm);
        Task Logout();

        Task<string[]> Register(RegisterViewModel vm, params Roles[] roles);
    }
}
