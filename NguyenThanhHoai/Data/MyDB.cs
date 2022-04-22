using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThanhHoai.Models;

    public class MyDB : DbContext
    {
        public MyDB (DbContextOptions<MyDB> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Comments> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<Comments>().ToTable("Comment");
        }

    }
