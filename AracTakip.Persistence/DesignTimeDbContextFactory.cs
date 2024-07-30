﻿using AracTakip.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AracTakip.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AracTakipAPIDBContext>
    {
        public AracTakipAPIDBContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AracTakipAPIDBContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
