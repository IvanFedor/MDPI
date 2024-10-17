﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
	public interface Student
	{
		string getName();
		int yourAnswerIs(int question);
		void setScore(int score);
		string showResult();
		bool equals(Student student);
		bool lessThan(Student student);
		bool greaterThan(Student student);
		int getLegajo();
	}
}
