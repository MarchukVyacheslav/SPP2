using System;
using System.Collections.Generic;

using FakerLibrary;
using ConsoleApp.Serialization;
using ConsoleApp.Writing;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker faker = new Faker();
            List<List<Person>> obj = faker.Create<List<List<Person>>>();
            MedCard medCard = faker.Create<MedCard>();

            ISerializer serializerJson = new JsonSerializer();
            ISerializer serializerXml = new myXmlSerializer();
            IWriter consoleWriter = new ConsoleWriter();
            IWriter fileWriter = new FileWriter(Environment.CurrentDirectory + "\\" + "FileName" + "." + "txt");
            string json = serializerJson.Serialize(obj);
            string xml = serializerXml.Serialize(obj);
            consoleWriter.Write(json);
            consoleWriter.Write(xml);
            fileWriter.Write(json);
            //fileWriter.Write(xml);

            //Console.ReadLine();
        }
    }
    public class Person
    {
        public bool alive;
        public string name;
        public MedCard medcard;
        public List<BusinessCard> businesscard;
        public DateTime birth;
        public int age { get; set; }
        public Person()
        {
        }
        private Person(string _name, bool _alive)
        {
            name = _name;
            alive = _alive;
        }

        public Person(string _name, int _age, bool _alive)
        {
            name = _name;
            alive = _alive;
            age = _age;
            throw new Exception();
        }
    }
    public struct MedCard
    {
        public double t;
        public Person person;
        public int id;
        public MedCard(int _id, Person _person, double _t)
        {
            t = 36 + _t;
            person = _person;
            id = _id;
        }
    }
    public struct BusinessCard
    {
        public int id;
        public string company;
        public Person person;
    }
}
