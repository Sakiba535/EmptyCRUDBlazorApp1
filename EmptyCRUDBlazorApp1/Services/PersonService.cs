using EmptyCRUDBlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyCRUDBlazorApp1.Services
{
    public class PersonService : IPersonService
    {
        private readonly PersonContext db;

        public PersonService(PersonContext db)
        {
            this.db = db;
        }

        public void AddPerson(Person person)
        {
            this.db.Persons.Add(person);
            this.db.SaveChanges();
        }

        public List<Person> GetPerson()
        {
            return this.db.Persons.ToList();
        }

        public Person? GetPersonById(int id)
        {
            return this.db.Persons.FirstOrDefault(x => x.ID == id);

        }
        public void UpdatePerson(Person person)
        {
            this.db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();

        }

        public void DeletePerson(int id)
        {
            var p = GetPersonById(id);
            if (p is null)
            {
                return;

            }
            this.db.Persons.Remove(p);
            this.db.SaveChanges();
        }


    }
}
