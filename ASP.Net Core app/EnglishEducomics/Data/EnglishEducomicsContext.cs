using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnglishEducomics.Models;

namespace EnglishEducomics.Models
{
    public class EnglishEducomicsContext : DbContext
    {
        public EnglishEducomicsContext (DbContextOptions<EnglishEducomicsContext> options)
            : base(options)
        {
        }

        public DbSet<EnglishEducomics.Models.Course> Course { get; set; }

        public DbSet<EnglishEducomics.Models.User> User { get; set; }

        public DbSet<EnglishEducomics.Models.Objective> Objective { get; set; }

        public DbSet<EnglishEducomics.Models.Lesson> Lesson { get; set; }

        public DbSet<EnglishEducomics.Models.Question> Question { get; set; }

        public DbSet<EnglishEducomics.Models.Answer> Answer { get; set; }
    }
}
