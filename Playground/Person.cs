#nullable enable
using System;
namespace Playground
{

    public class Person
    {
        public string FirstName { get; }
        public string? LastName { get; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int FirstNameLength()
        {
            return this.FirstName.Length;
        }
    }
}
