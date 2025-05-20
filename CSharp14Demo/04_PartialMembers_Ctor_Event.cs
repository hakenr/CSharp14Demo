using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.PartialMembers;

public partial class Demo
{
	// partial constructor
	public partial Demo();

	// partial event
	public partial event EventHandler MyEvent;
}


// usually source generated
public partial class Demo
{
	public partial Demo()
	{
		Console.WriteLine("Partial constructor called.");
	}

	public partial event EventHandler MyEvent
	{
		add
		{
			Console.WriteLine("Adding event handler.");
			_myEvent += value;
		}
		remove
		{
			Console.WriteLine("Removing event handler.");
			_myEvent -= value;
		}
	}
	private EventHandler _myEvent;
}
