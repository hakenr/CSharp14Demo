using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.LambdaParametersModifiers;

public class Demo
{
	delegate bool TryParse<T>(string text, out T result);

	public void Run()
	{
		// C# 13
		TryParse<int> parse1 = (string text, out int result) => Int32.TryParse(text, out result);

		// C# 14 - parameter modifiers no longer require specifying the parameter type
		TryParse<int> parse2 = (text, out result) => Int32.TryParse(text, out result);
	}
}
