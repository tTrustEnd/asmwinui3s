using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignmentWinUI.Core.Entities;

namespace AsignmentWinUI.Core.UseCases.LoginUseCase;
public interface ILoginUseCase
{
    Task<User> ExecuteAsync(string username);
}
