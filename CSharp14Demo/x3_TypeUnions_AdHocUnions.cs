using System;
using System.Collections.Generic;
using System.Text;
using Haken.CSharp14Demo.TypeUnions;
using static U;

namespace Haken.CSharp14Demo.TypeUnions;


(A or B or C) // similar to tuple types


// global naming
global using U = (A or B or C);


// construction
record A(int x, string y);
record B(int z);
record C() { public static C Singleton = new C(); };

(A or B or C) u = new A(10, "ten");


// deconstruction
if (u is A a) {...}

if (u is A(var x, var y)) { ... }


// Exhaustiveness
// If all member types are used in switch, no default case is needed. 
var x = u switch
{
	A a => a.x,
	B b => b.z,
	C c => 0
};


// Nullability - standard nullability notation
(A or B)? x = null;


// Equivalence
(A or B) x = new A(10, "ten");
(B or A) y = x;


// Assignability, Interchangeability, Covariance and Contravariance, Patterns, ...