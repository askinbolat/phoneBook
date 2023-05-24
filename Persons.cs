using System;

namespace phoneBook
{
    public class Persons
    {
        private string Name;
        private string Surname;
        private string Number;

        public string name { get => Name; set => Name = value; }
        public string surname { get => Surname; set => Surname = value; }
        public string number { get => Number; set => Number = value; }
        
        public Persons(){}
        public Persons(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }
        
        
    }
}