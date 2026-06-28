using System;

namespace RefactorClassRosterApp
{

	class Person
	{
		private string firstName;
		private string lastName;

		public Person()
		{
			firstName = "";
			lastName = "";
		}

		public Person(string newfirstName, string newlastName)
		{
			firstName = newfirstName;
			lastName = newlastName;
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
	}
}