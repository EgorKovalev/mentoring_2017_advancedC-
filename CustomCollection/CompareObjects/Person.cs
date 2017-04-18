using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection.CompareObjects
{
	public class Person : System.Object
	{
		private string FirstName;
		private string LastName;

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public override bool Equals(System.Object obj)
		{			
			if (obj == null) return false;
						
			Person person = (Person)obj;
			
			if ((System.Object)person == null) return false;

			return (this.FirstName.Equals(person.FirstName)) && (this.LastName.Equals(person.LastName));
		}

		public bool Equals(Person person)
		{
			if ((object)person == null) return false;

			return (this.FirstName.Equals(person.FirstName)) && (this.LastName.Equals(person.LastName));
		}

		public override int GetHashCode()
		{
			return 10;
		}
	}
}
