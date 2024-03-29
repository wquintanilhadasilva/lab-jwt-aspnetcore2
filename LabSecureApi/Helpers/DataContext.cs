﻿using LabSecureApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LabSecureApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
