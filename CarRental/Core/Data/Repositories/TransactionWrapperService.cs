using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Storage;

namespace CarRental.Core.Data.Repositories
{
    internal class TransactionWrapperService
    {
        private static AppDbContext dbContext;
        public static void Init(AppDbContext dbContext)
        {
            TransactionWrapperService.dbContext = dbContext;
        }
        public static IDbContextTransaction BeginTransaction()
        {
            return dbContext.Database.BeginTransaction();
        }
    }
}
