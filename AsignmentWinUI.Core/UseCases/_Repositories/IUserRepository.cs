using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases._Repositories;
public interface IUserRepository
{
    Task<User> GetUserByUsernameAsync(string username);
}
