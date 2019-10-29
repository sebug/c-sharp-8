# What's new in C# 8
Presentation: https://docs.google.com/presentation/d/1HBZk10De83ile86_qqS5zbY-3sTozwSIuBviVOta8BQ/edit#slide=id.g7076468f94_0_117

SharpLab -> C# to IL https://sharplab.io

in modifier: Passed by reference, but readonly.

Switch expressions

	myEnum switch
	{
		MyEnum.NONE => "a"
		_ => "Everything else"
	}

Deconstruct method - you can switch on what it gets deconstructed into.

Property pattern is nicer.

	point switch {
		{ X: var x, Y: var y } when x > 0 && y > 0 => true,
		_ => false
	}

Using declarations

	public void After(string path)
	{
		using var file = File.Create(path);
		file.WriteByte(1);
	}

static local functions - why not analyzed by the compiler?

^1 means words.Length - 1

## Non-nullable types
The compiler in the null reference exception will tell the location of where
things got null anyway.


	[NotNullWhen(false)]
	public static bool IsNullOrEmpty(string? s)




