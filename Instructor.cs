using System;

namespace RefactorClassRosterApp
{
	class Instructor : Person
	{

		private string contactInfo;

		public Instructor() : base()
		{
			contactInfo = "";
		}

		public Instructor(string newFirstName, string newLastName, string newContactInfo) : base(newFirstName, newLastName)
		{
			contactInfo = newContactInfo;
		}

		public string ContactInfo
		{
			get { return contactInfo; }
			set { contactInfo = value; }
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " - " + ContactInfo;
		}


	}
}