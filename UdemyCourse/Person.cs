using System;

namespace UdemyCourse // Namesoace is a container for classes.
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
