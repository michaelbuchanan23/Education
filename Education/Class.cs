using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Class {

		public string Name { get; set; }
		public string Language { get; set; } //CSharp or Java
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }

		//Greg stated that no one does fixed arrays like below anymore b/c everyone uses dynamic arrays
		//public Student [] Students = new Student [16]; //creates an array with all students info in the class(used 16 b/c that is max class capacity) -- get/set not needed on collections, only on individuals

		// the below creates a dynamic array and is how everyone does this today
		public List<Student> Students = new List<Student>();

	}
}
