using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.ImplicitSpanConversions;

public static class MyExtensions
{
	public static bool HasSingle<T>(this ReadOnlySpan<T> span, T value) { return true; }
}

public class  Demo
{
	public static void Run()
	{
		ReadOnlySpan<char> myReadOnlySpan = stackalloc char[10];
		Span<char> mySpan = stackalloc char[10];
		char[] myArray = new char[10];
		string someType = "Test";

		myReadOnlySpan.HasSingle('x'); // just works

		mySpan.HasSingle('x');   // C# 14 
		myArray.HasSingle('x');  // C# 14
		someType.HasSingle('x');   // C# 14 if there is an implicit conversion operator to Span/ReadOnlySpan/T[]
	}

	
}
