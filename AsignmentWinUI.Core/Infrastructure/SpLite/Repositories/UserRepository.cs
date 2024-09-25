using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.Infrastructure.SpLite.DataContext;
using AsignmentWinUI.Core.UseCases._Repositories;
using Microsoft.EntityFrameworkCore;

namespace AsignmentWinUI.Core.Infrastructure.SpLite.Repositories;
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;
    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> GetUserByUsernameAsync(string UserName)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == UserName);
    }
}
