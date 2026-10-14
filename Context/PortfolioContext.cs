using Microsoft.EntityFrameworkCore;
using MYacademy_Portfolio.Entities;

namespace MYacademy_Portfolio.Context
{
    public class PortfolioContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
