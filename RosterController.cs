using System;

namespace RefactorClassRosterApp
{
	class RosterController
	{
		RosterModel myModel;
		RosterView myView;
		public RosterController()
		{

			myModel = new RosterModel();
			myView = new RosterView();

			myView.TestApplication();

			myView.WriteString("Enter Course Instructor");

			myView.Write("First Name: ");
			string firstName = myView.ReadString();

			myView.Write("Last Name: ");
			string lastName = myView.ReadString();

			myView.Write("Contact Email: ");
			string contactInfo = myView.ReadString();

			myModel.addInstructor(firstName, lastName, contactInfo);


	bool keepRunning = true;

			while (keepRunning)
			{
				myView.DisplayMenu();

				string choice = myView.ReadString();

				switch (choice)
				{
				case "1":

					myView.WriteString("Enter Course Student");

					myView.Write("First Name: ");
					firstName = myView.ReadString();

					myView.Write("Last Name: ");
					lastName = myView.ReadString();

					myView.Write("Class Rank: ");
					string classRank = myView.ReadString();

					myModel.addStudent(firstName, lastName, classRank);

				break;

				case "2":

					myView.WriteString("Enter Course Instructor");

					myView.Write("First Name: ");
					firstName = myView.ReadString();

					myView.Write("Last Name: ");
					lastName = myView.ReadString();

					myView.Write("Contact Email: ");
					contactInfo = myView.ReadString();

					myModel.addInstructor(firstName, lastName, contactInfo);

				break;

				case "3":

						myView.PrintRoster(
						myModel.getInstructors(),
						myModel.getStudents());

					break;

				case "4":

					keepRunning = false;

					break;

				default:

					myView.WriteString("Invalid choice");

				break;
				}
			}
		}
	}
}