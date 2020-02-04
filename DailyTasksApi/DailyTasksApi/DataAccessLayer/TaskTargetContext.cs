using DailyTasksApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DailyTasksApi.DataAccessLayer
{
    public class TaskTargetContext:DbContext
    {
        public TaskTargetContext(DbContextOptions<TaskTargetContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Learn Java", Duration=10, CreationDate= DateTime.Now},
                new Item { Id = 2, Name = "Learn JS", Duration=5, CreationDate = DateTime.Now}              
                );
        }
        }
}
