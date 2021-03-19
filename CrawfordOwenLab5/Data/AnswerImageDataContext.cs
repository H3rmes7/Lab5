using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrawfordOwenLab5.Models;

namespace CrawfordOwenLab5.Data
{
    public class AnswerImageDataContext : DbContext
    {
        public AnswerImageDataContext(DbContextOptions<AnswerImageDataContext> options) :base(options)
        {}

        public DbSet<AnswerImage> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<AnswerImage>().ToTable("Images");
        }

    }
}
