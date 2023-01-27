using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDUsingApi.Models
{
    public class FriendContext : DbContext
    {
        public FriendContext(DbContextOptions<FriendContext> options) : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
    }
}
