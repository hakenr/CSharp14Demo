using System;
using System.Collections.Generic;
using System.Text;

namespace Haken.CSharp14Demo.TypeUnions;


union U // Standard Unions
{
	ClassA(int x, string y);
	ClassB(int z);
	ClassC;
}


// construction
U u = new ClassA(10, "ten");


// deconstruction
if (u is ClassA a) { ... }

if (u is ClassA(var x, var y)) { ... }

if (u is ClassA { y: var y }) { ... }


// Exhaustiveness
// If all member types are used in switch, no default case is needed. 
var x = u switch
{
	ClassA a => a.x,
	ClassB b => b.z,
	ClassC c => 0
};


// Nullability - standard nullability notation
U? u = null;

// https://github.com/dotnet/csharplang/blob/main/proposals/TypeUnions.md