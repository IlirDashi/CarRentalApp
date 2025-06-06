using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Data.Repositories;
using CarRental.Core.Common;

namespace CarRental.Core.Logic;

    public class PersonsManager
    {
    public void AddPerson(Person p)
    {

        PersonsRepository.Add(new Data.Entities.Person
        {
            FullName = p.FullName,
            Password = p.Password,
            PhoneNo = p.PhoneNo,
            Role = p.Role,
            Email = p.Email
        });
    }

    public void Update(int id, Person p) 
    {
        var dbUser = Program.DbContext.Persons.Find(id) ?? 
            throw new CarRentalException("Nuk u identifikua personi!");
        
        dbUser.FullName = p.FullName;
        dbUser.Email = p.Email;
        dbUser.PhoneNo = p.PhoneNo;
        dbUser.Role = p.Role;
        if(p.Password != null)
        {
            dbUser.Password = p.Password;
        }
        Program.DbContext.SaveChanges();
    }
    
    internal List<Person> GetAll()
    {
        return Program.DbContext
                      .Persons.Select(dbUser => new Person
                      {
                          Id = dbUser.Id,
                          FullName = dbUser.FullName,
                          Email = dbUser.Email,
                          PhoneNo = dbUser.PhoneNo,
                          Role = dbUser.Role
                      })
                      .ToList();
    }

    public Person? GetById(int id)
    {
        var person = PersonsRepository.GetById(id);
        return new Person
        {
            Id = person.Id,
            Email = person.Email,
            FullName = person.FullName,
            PhoneNo = person.PhoneNo,
            Role = person.Role
        };
    }

    internal void Delete(Person user)
    {
        PersonsRepository.Remove(user.Id);
    }

    internal Person? Login(string email, string password)
    {
        var dbUser = Program.DbContext
                            .Persons
                            .FirstOrDefault(x => x.Email == email && x.Password == password);
        if(dbUser == null)
        
            return null;
            return new Person
            {
                Id = dbUser.Id,
                FullName = dbUser.FullName,
                Email = dbUser.Email,
                PhoneNo = dbUser.PhoneNo,
                Role = dbUser.Role
            };
        }
    }
    

