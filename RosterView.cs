using System;

namespace RefactorClassRosterApp
{
	class RosterView
	{
		public void WriteString(String text)
		{
			Console.WriteLine(text);
		}

		public void Write(String text)
		{
		Console.Write(text);
		}

		public string ReadString()
		{
			return Console.ReadLine();
		}

		//Test Each of the Classes & Objects
		public void TestApplication()
		{
			Instructor myTeacher1 = new Instructor("First Name", "Last Name", "Contact Email");
			Instructor myTeacher2 = new Instructor();
			myTeacher2.FirstName = "Steven";
			myTeacher2.LastName = "Millet";
			myTeacher2.ContactInfo = "steven.millet@doane.edu";

			Student myStudent1 = new Student("First Name", "Last Name", "Class Rank");
			Student myStudent2 = new Student();
			myStudent2.FirstName = "Adam";
			myStudent2.LastName = "Razey";
			myStudent2.ClassRank = "Senior";

			Console.WriteLine("Class Roster Demonstration");
			Console.WriteLine("--------------------------");


			Console.WriteLine("Instructor Required Information");
			Console.WriteLine(myTeacher1);
			Console.WriteLine("");


			Console.WriteLine("Instructor Example");
			Console.WriteLine(myTeacher2);
			Console.WriteLine("");

			Console.WriteLine("Student Required Information");
			Console.WriteLine(myStudent1);
			Console.WriteLine("");

			Console.WriteLine("Student Example");
			Console.WriteLine(myStudent2);
			Console.WriteLine("");

			//Beginning of the Class Roster Application
			Console.WriteLine("Now Starting Class Roster App");
			Console.WriteLine("-----------------------------");
		}


		public void DisplayMenu()
		{
			Console.WriteLine("1. Add Student");
			Console.WriteLine("2. Add Instructor");
			Console.WriteLine("3. Print Roster");
			Console.WriteLine("4. Exit");
			Console.Write("Selected A Option Number: ");
		}

		public void PrintRoster(List<Instructor> instructors, List<Student> students)
		{
			Console.WriteLine(" Printing Class Roster ");
			Console.WriteLine("-----------------------");
			Console.WriteLine("");

			Console.WriteLine("   Class Instructors   ");
			Console.WriteLine("-----------------------");

			foreach (Instructor instructor in instructors)
			{
				Console.WriteLine(instructor);
			}

			Console.WriteLine("");
			Console.WriteLine("     Class Students    ");
			Console.WriteLine("-----------------------");

			foreach (Student student in students)
			{
				Console.WriteLine(student);
			}

			Console.WriteLine("");
			Console.WriteLine("-----------------------");
			Console.WriteLine("All Enrolled In Section");
		}
	}
}
