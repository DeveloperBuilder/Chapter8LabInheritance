using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8LabInheritance
{
    class Program
    {
        /* create a console application using the following specifications:
         * Interface: Profession
         * Methods in Profession: GetName(), GetProfession()
         * Interface: Family
         * Methods in Family: GetMarried(), GetChildren()
         * Class: Person that implements Profession and Family
         Make use of the Person class in your program */
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.GetName();
            person.GetProfession();
            person.GetMarried();
            person.GetChildren();
            Console.ReadLine();
        }
    }

    public interface Profession
    {
        void GetName();
        void GetProfession();
    }

    public interface Family
    {
        void GetMarried();
        void GetChildren();
    }

    class Person : Profession, Family
    {
        public void GetName()
        {
            Console.WriteLine("My name is Bob");
        }
        public void GetProfession()
        {
            Console.WriteLine("I work as a denist");
        }
        public void GetMarried()
        {
            Console.WriteLine("I am married to Marloes");
        }
        public void GetChildren()
        {
            Console.WriteLine("I have 2 children");
        }
    }
}
