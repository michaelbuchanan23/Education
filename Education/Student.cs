using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Student {
		public string Name { get; set; }
		public Class Class { get; set; }
		public string ContactInfo { get; set; }
		public DateTime? FirstJob { get; set; } //the ? makes this variable nullable
		public int Absences { get; set; }
		public List<Assignment> Assignments = new List<Assignment>(); //creates a new dynamic array for assignments for the Student class
	}
}
