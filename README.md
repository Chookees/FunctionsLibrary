[![Download Functions Library](https://img.shields.io/sourceforge/dt/functionslibrary.svg)](https://sourceforge.net/projects/functionslibrary/files/latest/download)

# Functions Library
This is a Functions Library/Wrapper written in C# .NetCore 2.0


# How to use
1.) Add a reference to the MathFunctions.dll located in the debug folder.

2.) If you use Console use it like: "Console.WriteLine(Functions.Math.Subtract.CalculateDouble(5.5, 5));"

 Or if you use Forms or WPF: "textBox1.Text = MathFunction.Basic.Subtract.CalculateDouble(5.5, 5).ToString();"

=> Result will be = 0.5

# Bugs and Workarounds

/

# Notes/Changelog

**To Do's**

	=> Wrap up more functions which in my eye are essential
	
	=> Specific errors instead of none or a false bool


**Current Version 1.1.1.1**
	
	=> Fixed a bug where TextFile.Create would not create a TextFile
	
	=> Changed Namespace of Functions.Math
	
	=> Fixes a bug where Math.SquareRoot.Calculate would not deliver the right answer
	
	[![Download Functions Library](https://a.fsdn.com/con/app/sf-download-button)](https://sourceforge.net/projects/functionslibrary/files/latest/download)


Version 1.1.1.0

=> Changed Project name to Functions

=> Created Functions.Math.Pi

=> Created Functions.Math.Number
	
=> Created Functions.Date
	
=> Created Functions.Start
	
=> Created Functions.TextFile
	
=> Update all other


Version 1.0.1.0 

=> All Basic functions with up to 5 Values.

=> Square root function added with classic and repeating function.

	
Version 1.0.0.0 

=> Only Basic functions with Addition up to 3 Values.

# Current functions are:

=> Addition with with up to 5 Values

=> Subtraction with up to 5 Values

=> Multiplication with up to 5 Values

=> Division with up to 5 Values

=> Square Root calculation (Classic and with repeat)

=> Exponential calculation

=> Pi Multiplication/Division | Get Pi as MD5, Get Pi with 2,4,6 Decimals or complete

=> Checking a Number - IsEven ; IsCompletlyDisivisble ; IsPrime

=> Everything about Date - GetCurrentDateAsString ; GetCurrentTimeAsString ; IsLeapYear ; IsNewerFromString

=> Start - SpecificProgram ; SetPriorityTaskRealtime

=> TextFile - Create ; WriteWithOverwrite ; Write ; Read ; Delete
