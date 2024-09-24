using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases._Repositories;
using Microsoft.EntityFrameworkCore;
using AsignmentWinUI.Core.Infrastructure.SpLite.DataContext;

namespace AsignmentWinUI.Core.Infrastructure.SpLite.Repositories;

public class GroupMemberRepository : IGroupMembersRepository
{
    private readonly AppDbContext _dbContext;
    public GroupMemberRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<GroupMember>> GetOnlineGroupMembersAsync(int groupID)
    {
        try
        {
            return await _dbContext.GroupMembers
                         .Include(gm => gm.User)
                         .Where(gm => gm.GroupID == groupID && gm.User.IsOnline == true)
                         .ToListAsync();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
