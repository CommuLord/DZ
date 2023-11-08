using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DZ
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public string Clikuha { get; set; }
        public int Balance { get; set; }
        public Person(string name, int age, string company, string clikuha, int balance)
        {
            Name = name;
            Age = age;
            Company = company;
            Clikuha = clikuha;
            Balance = balance;
        }
    }
}
