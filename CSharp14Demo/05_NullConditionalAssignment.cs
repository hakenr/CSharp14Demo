using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.NullConditionalAssignment;

public class Demo
{
	private Person _person;

	public void Run()
	{
		// C# 13
		if (_person != null)
		{
			_person.Name = "John Doe";
		}

		// C# 14 - Null-conditional assignment
		_person?.Name = "John Doe";
		_person?.NameChanged += (s, e) => Console.WriteLine("Name changed!");

		// not allowed in C# 14 (yet?)
		// _person?.Age++;

		// in discussion for C# vNext
		// await? person?.DoSomethingAsync();
	}



	private record Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public event EventHandler NameChanged;
	}
}



