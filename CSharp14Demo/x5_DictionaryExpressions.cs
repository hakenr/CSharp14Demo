using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.DictionaryExpressions;

public class Demo
{
	public void Run()
	{
		Dictionary<string, int> currentStudents = ["joe" : 1, "jane" : 2, "john" : 3];
		Dictionary<string, int> newStudents = [.. currentStudents, "mds" : 5];
	}	
}


// https://github.com/dotnet/csharplang/issues/8659
// https://github.com/dotnet/csharplang/blob/main/proposals/dictionary-expressions.md