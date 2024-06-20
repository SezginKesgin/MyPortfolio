using Microsoft.EntityFrameworkCore;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.DataAccessLayer.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NGKF6I6;initial Catalog=MyPortfolioDb;integrated Security=true;");
            
        }
        public DbSet<About> abouts { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<ToDoList> toDoLists { get; set; }
    }
}
