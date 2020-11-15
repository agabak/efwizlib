using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wizlib.Model.Models;

namespace Wizlib.DataAccess.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
