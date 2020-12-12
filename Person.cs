using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate1
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }
        public Person()
        {
            Name = "-1";
            Surname = "-1";
            Age = -1;
        }
        public override string ToString()
        {
            return $"\nName:{Name}\nSurname:{Surname}\nAge:{Age}";
        }
    }
}
