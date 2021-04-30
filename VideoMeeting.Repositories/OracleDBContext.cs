using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoMeeting.Model;

namespace VideoMeeting.Repositories
{
    public class OracleDBContext:DbContext
    {
        public OracleDBContext(DbContextOptions<OracleDBContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(user => user.Id);
        }
        public DbSet<User> Users { get; set; }
    }
}
