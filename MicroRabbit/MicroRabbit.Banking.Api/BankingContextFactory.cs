using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Api
{
    public class BankingContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=BankingDb;Trusted_Connection=True;MultipleActiveResultSets=True");

            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}
