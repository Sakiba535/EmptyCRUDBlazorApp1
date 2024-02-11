using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyCRUDBlazorApp1.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string? PersonName { get; set; }
    }

    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public PersonContext(DbContextOptions opt) : base(opt)
        {

        }

    }
}
