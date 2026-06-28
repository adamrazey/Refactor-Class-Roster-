using System;

namespace RefactorClassRosterApp
{
	class Student : Person
	{
		private string classRank;
		
		public Student() : base()
		{
			classRank = "";
		}

		public Student(string newFirstName, string newLastName, string newClassRank) : base(newFirstName, newLastName)
		{
			classRank = newClassRank;
		}

		public string ClassRank
		{
			get{ return classRank; }
			set{ classRank = value;  }
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " - " + ClassRank;
		}
	}
}

