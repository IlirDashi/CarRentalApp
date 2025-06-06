using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Common;

namespace CarRental.Core.Data.Repositories;

    public class PersonsRepository
    {
        private static AppDbContext appDbContext;

        public static void Init(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }

        public static void Add(Data.Entities.Person entity)
        {
            appDbContext.Persons.Add(entity);
            appDbContext.SaveChanges();
        }

        public static Data.Entities.Person? GetById(int id) {
            return appDbContext.Persons.Find(id) ??
                throw new CarRentalException("Nuk mund te identifikohej perdoruesi!");
    }
        public static void Remove(int id)
        {
            var person = GetById(id);
            appDbContext.Persons.Remove(person);
            appDbContext.SaveChanges() ;
        }
}
