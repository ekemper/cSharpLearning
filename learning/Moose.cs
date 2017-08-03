using System;
namespace learning
{
	class Moose
	{

		public string Name;
		public bool Antlers;
		public string Email;

		public static int Population;

		public Moose(string name, bool antlers, string email)
		{
			Name = name;
			Population = Population + 1;
		}

		// static int FeetToInches (int feet)
		// {
		//  int inches = feet * 12;
		//  return inches;
		// }
	}
}



