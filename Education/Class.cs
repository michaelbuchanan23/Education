using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Class {

		public string Name { get; set; }
		private string _Language; //this variable is so that we limit the Language variable to only CSharp or Java
		/// <summary>
		/// Language accepts only CSharp of Java
		/// </summary>
		public string Language {
			get { //the get method represents the method that gets called when someone tries to read this variable (right side of equal)
				return _Language;
			}
			set { //the set method represents the left side of equal wherein one will set the value of this variable
				if (value == "CSharp" || value == "Java") {//the variable "value" represents the data someone is trying to put in this variable -- we can filter this data to make sure it's either CSharp of Java
					_Language = value;
				} else {
					throw new ApplicationException("Language must be CSharp of Java");
				}
			}
		}
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }

		//Greg stated that no one does fixed arrays like below anymore b/c everyone uses dynamic arrays
		//public Student [] Students = new Student [16]; //creates an array with all students info in the class(used 16 b/c that is max class capacity) -- get/set not needed on collections, only on individuals

		// the below creates a dynamic array and is how everyone does this today
		public List<Student> Students = new List<Student>();

		public void DistributeAssignment (Assignment assignment) {
			foreach (Student student in Students) {
				Assignment asgn = new Assignment();
				asgn.AssignmentId = assignment.AssignmentId;
				asgn.Name = assignment.Name;
				asgn.Comments = assignment.Comments;
				asgn.Grade = assignment.Grade;
				student.Assignments.Add(asgn);
			}
		}

		//try catch  -- move this to its own solution and upload to github
		/*
		try {
			int x = 0;
			int y = 1 / x;
		} catch(DivideByZeroException ex) {
			Console.WriteLine(ex.Message);
		} catch (Exception ex) {
			throw ex; //this will cause the program to blow - which is the same thing that happens when the program blows
		}
		*/
	}
}
