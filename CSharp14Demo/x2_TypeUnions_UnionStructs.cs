using System;
using System.Collections.Generic;
using System.Text;
using static U;

namespace Haken.CSharp14Demo.TypeUnions;


union struct U // Union Structs
{
	StructA(int x, string y);
	StructB(int z);
	StructC;
}


// construction
U u = new StructA(10, "ten");


// deconstruction
if (u is StructA a) { ... }

if (u is StructA(var x, var y)) { ... }

if (u is StructA { y: var y }) { ... }


// Exhaustiveness
// If all member types are used in switch, no default case is needed. 
var x = u switch
{
	StructA a => a.x,
	StructB b => b.z,
	StructC c => 0
};


// Nullability - standard nullability notation
U? u = null;


// Default
U u = default; // undefined state, compiler warning

var x = u switch // switch throws, since not A, B or C
{
	StructA a => a.x,
	StructB b => b.z,
	StructC c => 0
}

union struct U
{
	A(int x, string y);
	B(int z);
	C = default; // you can define a default state for the union struct
}
