using System;

namespace RefactorClassRosterApp
{
	class RosterModel
	{
		private List<Instructor> instructors;
		private List<Student> students;


		public RosterModel ()
		{
			instructors = new List<Instructor> ();
			students = new List<Student>();
		}

		public void addInstructor(string firstName, string lastName, string contactInfo)
		{
			Instructor newInstructor = new Instructor(firstName, lastName, contactInfo);
			instructors.Add(newInstructor);
		}
		public void addStudent(string firstName, string lastName, string classRank)
		{
			Student newStudent = new Student(firstName, lastName, classRank);
			students.Add(newStudent);
		}

		public List<Instructor> getInstructors()
		{
			return instructors;
		}

		public List<Student> getStudents()
		{
			return students;
		}

	}
}
