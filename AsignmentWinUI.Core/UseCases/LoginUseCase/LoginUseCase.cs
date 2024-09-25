using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases._Repositories;

namespace AsignmentWinUI.Core.UseCases.LoginUseCase;
public class LoginUseCase : ILoginUseCase
{
    private readonly IUserRepository _userRepository;

    public LoginUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> ExecuteAsync(string username)
    {
        var user = await _userRepository.GetUserByUsernameAsync(username);
        if (user != null)
        {
            return user;
        }
        return null;
    }
}
