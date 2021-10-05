using System;
using System.Collections.Generic;

using FakerLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker faker = new Faker();
            Person obj = faker.Create<Person>();
            Console.ReadLine();
        }

        public class Person
        {
            public bool _flag;
            public string _name;
            public BusinessCard _card1;
            public BusinessCard _card2;
            public int _age { get; set; }
            public Person()
            {
                _flag = false;
            }

            private Person(bool flag)
            {
                _flag = flag;
            }

            private Person(string name, bool flag)
            {
                _name = name;
                _flag = flag;
            }

            public Person(string name, int age, bool flag)
            {
                _name = name;
                _flag = flag;
                _age = age;
                throw new Exception();
            }
        }

        public class BusinessCard
        {
            public Person _person;

            public int id;
        }
    }
}
