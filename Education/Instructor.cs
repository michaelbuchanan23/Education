using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Instructor {

		public string Name { get; set; }
		public int ExperienceInYears { get; set; }
		public string PrimaryLanguage { get; set; } //CSharp of Java
		public string Email { get; set; }
		public string PhoneNumber { get; set; }

		//method that creates assignment and distributes one copy of the assignment to each student in a given class
		public Assignment CreateAssignment(string name, string assignmentId) {
			Assignment asgn = new Assignment();
			asgn.Comments = null;
			asgn.Grade = null;
			asgn.Name = name;
			asgn.AssignmentId = assignmentId;
			return asgn;
		}
	}
}
