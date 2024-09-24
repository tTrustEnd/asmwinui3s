using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using AsignmentWinUI.Core.Infrastructure.SpLite.DataContext;

namespace AsignmentWinUI.Core.Infrastructure.SpLite.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly AppDbContext _dbContext;
    public MessageRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(_dbContext));
    }
    public async Task SaveMessageAsync(Message message)
    {
        _dbContext.Messages.Add(message);
        await _dbContext.SaveChangesAsync();
    }
    public async Task<IEnumerable<Message>> GetMessagesAsync()
    {
        Debug.WriteLine("HAHA");
        try
        {
            return await _dbContext.Messages.Include(m => m.User)
                                            .Include(m => m.Group)
                                            .ToListAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
   
}
