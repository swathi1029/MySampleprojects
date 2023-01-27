
using MVCAppln.Models;
using Microsoft.EntityFrameworkCore;



namespace MVCAppln
{
    public class FriendsContext : DbContext
    {
        public FriendsContext(DbContextOptions<FriendsContext> options) : base(options)
        {
        }

        public DbSet<Friend> Customers { get; set; }
    }
}