using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdlP_Practica1
{
	public interface IteratorOfStudent
	{
		void beginning();
		bool end();
		Student current();
		void next();
	}
}
