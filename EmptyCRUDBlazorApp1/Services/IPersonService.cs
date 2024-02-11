﻿using EmptyCRUDBlazorApp1.Models;

namespace EmptyCRUDBlazorApp1.Services
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        void DeletePerson(int id);
        List<Person> GetPerson();
        Person? GetPersonById(int id);
        void UpdatePerson(Person person);
    }
}