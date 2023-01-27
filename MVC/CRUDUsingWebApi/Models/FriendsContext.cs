
using CRUDUsingWebApi.Models;
using Microsoft.EntityFrameworkCore;



namespace CRUDUsingWebApi
{
    public class FriendsContext : DbContext
    {
       

        public FriendsContext(DbContextOptions<FriendsContext> options) : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
    }
}