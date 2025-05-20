namespace Haken.CSharp14Demo.ExtensionMembers;

// C# 13 - only Extension Methods
public static class StringExtensionsOld
{
	public static string LeftOld(this string str, int length)
	{
		return str.Substring(0, length); // shortened for demo purposes
	}
}

// C# 14 - Extension Members
public static class StringExtensions // still a static class host
{
	extension(string str) // extension block
	{
		public string Left(int length) // extension method (instance method)
		{
			return str.Substring(0, length); // shortened for demo purposes
		}

		public static bool IsNullOrNewLine(string value) // extension method (static method)
		{
			return (value == null) || (value == "\n") || (value == "\r\n") || (value == "\r");
		}

		public long NormalizedLength // extension property (cannot add new state!)
		{
			get
			{
				if (str == null) throw new ArgumentNullException(nameof(str));
				return str.GetNormalizedLength();
			}
		}
	}
}

public class Demo
{
	public static void Run()
	{
		string str = "Hello, World!";
		Console.WriteLine(str.Left(5));

		Console.WriteLine(string.IsNullOrNewLine(null));
		Console.WriteLine(string.IsNullOrNewLine("\n"));

		Console.WriteLine(str.NormalizedLength);
	}
}
