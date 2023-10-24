using IdentityMessageBoard.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityMessageBoard.DataAccess
{
    public class MessageBoardContext : IdentityDbContext<ApplicationUser> // this line needs to be updated!
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public MessageBoardContext(DbContextOptions<MessageBoardContext> options) : base(options)
        {

        }
    }
}
