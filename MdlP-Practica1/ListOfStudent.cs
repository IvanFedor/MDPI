using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
	internal class ListOfStudent : Collection
	{
		private List<Student> list = new List<Student>();

		public IteratorOfStudent getIterator()
		{
			return new ListOfStudentIterator(list);
		}

		public void addStudent(Student student)
		{
			list.Add(student);
		}

		public void sort()
		{
			list.Sort(new StudentComparer());
		}
	}
}
