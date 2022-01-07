using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExceptions;

namespace Exceptions
{
    class Dog
    {
        int age;
        string name;

        public Dog(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age {
            get => this.age;
            set {
                if (value < 0)
                {
                    throw new LowerThanLimitDogAgeException();
                }
               else if (value > 100)
                {
                    throw new GreaterThanLimitDogAgeException();
                }
                else
                {
                    this.age = value;
                }        
            }
        }

        public string Name {
            get => this.name; 
            set
            {
                if (value.Length < 2)
                {
                    throw new InvalidDogNameException();
                }
                else
                {
                    this.name = value;
                }

            } 
        }

    }
}
