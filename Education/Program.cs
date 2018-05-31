﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Program {
		static void Main(string[] args) {

			Instructor danTheMan = new Instructor();
			danTheMan.Name = "Dan";
			danTheMan.ExperienceInYears = 17;
			danTheMan.PrimaryLanguage = "CSharp";
			danTheMan.Email = "danTheMan@military.gov";
			danTheMan.PhoneNumber = "123-456-7890";
						

			Class dotnetbc4 = new Class();
			dotnetbc4.Capacity = 16;
			dotnetbc4.Code = "DN4";
			dotnetbc4.Language = "CSharp";
			dotnetbc4.Name = "Dot Net Boot Camp 4";
			dotnetbc4.Instructor = danTheMan; // we have to put an instance of instructor in here so we use our instance of danTheMan from above

			//Console.WriteLine(dotnetbc4.Instructor.Name);

			Student foster = new Student();
			foster.Absences = 0;
			foster.ContactInfo = "Call Foster...";
			foster.FirstJob = DateTime.MinValue; //this is a way to later say the date/time doesn't exist (probably by an if statement)
			foster.Name = "Foster";
			foster.Class = dotnetbc4;

			Student jj = new Student();
			jj.Absences = 0;
			jj.ContactInfo = "Call JJ...";
			jj.FirstJob = DateTime.MinValue;
			jj.Name = "Jonathan";
			jj.Class = dotnetbc4;

			//don't add to arrays as shown below hence the comment signs
			//dotnetbc4.Students[0] = foster;
			//dotnetbc4.Students[1] = jj;

			//instead add things to the array in the following manner
			dotnetbc4.Students.Add(foster);
			dotnetbc4.Students.Add(jj);

			//Console.WriteLine(dotnetbc4.Students[0].Name);
		}
	}
}
