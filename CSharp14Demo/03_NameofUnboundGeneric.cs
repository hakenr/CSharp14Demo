namespace Haken.CSharp14Demo.NameofUnboundGeneric;

public class Demo
{
	public const string ListNameOld = nameof(List<int>); // C# 13 - "List"

	public const string ListName = nameof(List<>); // C# 14 - "List"
}
