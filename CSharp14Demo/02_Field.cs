using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.Field;

public class Demo
{
	// C# 13
	private string _msg;
	public string MessageOld
	{
		get => _msg;
		set => _msg = value ?? throw new ArgumentNullException(nameof(value));
	}

	// C# 14
	public string Message
	{
		get;
		set => field = value ?? throw new ArgumentNullException(nameof(value));
	}
}

public class Collision
{
	private string field;
	public string Field
	{
		get => field;
		set => field = value ?? throw new ArgumentNullException(nameof(value));
	}

	public void ProcessField()
	{
		Console.WriteLine(field);
	}
}
