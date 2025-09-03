using System.Numerics;

namespace Haken.CSharp14Demo.ExtensionMembersFactories;

public static class MyFactories
{
	extension<TNumber>(TNumber source) where TNumber : INumber<TNumber>
	{
		public static IEnumerable<TNumber> Range(TNumber start, int count)
		{
			for (int i = 0; i < count; i++)
			{
				yield return start++;
			}
		}
	}
}

public class Demo
{
	public static void Run()
	{
		// regular static method call
		var ints = MyFactories.Range<int>(10, 5);

		// static extension method call syntax
		var integers = int.Range(10, 5);
		var longs = long.Range(10, 5);
		var unsignedLongs = ulong.Range(10u, 5);
	}
}
