using System;

namespace PersonList
{
    class Person
    {
        private string _name;
        private int _age;
        
        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            //this method requires users to have a name and age at creation
        }

        public override string ToString()
        {
            return "Name: " + _name;
        }

        public void CheckDuplicate()
        {
            if ()
        }
    }
}
