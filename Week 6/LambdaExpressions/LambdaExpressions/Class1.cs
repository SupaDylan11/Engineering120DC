using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Person
    {
        public string Name { get; private set; }
        private int _age;
        public int Age {
            get { return _age; }
            set { if (value < 0)
                    throw new ArgumentOutOfRangeException();
                  else
                    _age = value;
            } }
        public string City { get; private set; }

        public Person(string name, string city, int age)
        {
            Name = name;
            City = city;
            _age = age;
        }
    }
}
