# Tabulate
A simple extension method to format strings with fixed length.

## Get it
This class library is not yet on NuGet. You can get a precompiled binary
in the "releases" section of this repository or you can compile it
yourself.

## Definition
The definition of `Tabulate` extension method is quite straight-forward:
```c#
public static string Tabulate(this string str, int length, char fill = ' ')
```
When `length` is positive, the string will be left-padded with the fill
character, when negative it will be right-padded with the fill
character, when 0 the method will return an empty string.

When the length of the string is greater than (absolute) `length`, the
string will be left-truncated if `length` is positive, right-truncated
if negative.

## Examples
```c#
"a".Tabulate(4);       // result: "   a"
"a".Tabulate(-4);      // result: "a   "
"a".Tabulate(-4, '.'); // result: "a..."
"abcde".Tabulate(4);   // result: "abcd"
"abcde".Tabulate(-4);  // result: "abcd"
```
