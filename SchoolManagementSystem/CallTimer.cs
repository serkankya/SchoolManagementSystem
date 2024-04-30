using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
	public static class CallTimer
	{
		public static string Start()
		{
			return DateTime.Now.ToString($"dddd  -  dd/MM/yyyy  -  HH:mm:ss");
			//eklenecek
		}
	}
}
