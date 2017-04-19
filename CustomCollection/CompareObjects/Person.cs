using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection.CompareObjects
{
	public class Person
	{
		private readonly string FirstName;
		private readonly string LastName;

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public bool Equals(Person person)
		{
			if ((object)person == null) return false;

			return (this.FirstName.Equals(person.FirstName)) && (this.LastName.Equals(person.LastName));
		}

		public override int GetHashCode()
		{
			return (FirstName + LastName).GetHashCode();
		}

		public static bool operator == (Person a, Person b)
		{
			if (System.Object.ReferenceEquals(a, b)) return true;
			
			if (((object)a == null) || ((object)b == null)) return false;

			return a.Equals(b);
		}

		public static bool operator != (Person a, Person b)
		{
			return !(a == b);
		}
	}
}
