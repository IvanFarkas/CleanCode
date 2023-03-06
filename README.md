# CleanCode

## An effort to build clean code

## [ReSharper command line tools](https://www.jetbrains.com/help/resharper/ReSharper_Command_Line_Tools.html)

	dotnet tool install -g JetBrains.ReSharper.GlobalTools

### [CleanupCode Command-Line Tool](https://www.jetbrains.com/help/resharper/CleanupCode.html)

	jb cleanupcode CleanCode.sln
	jb cleanupcode -p="Built-in: Reformat & Apply Syntax Style" CleanCode.sln

### [InspectCode Command-Line Tool](https://www.jetbrains.com/help/resharper/InspectCode.html)

	jb inspectcode CleanCode.sln -f="sarif" -o=CodeIssues.json

### [Code analysis](https://www.jetbrains.com/help/resharper/Code_Analysis__Index.html)

### [Code Inspections in C#](https://www.jetbrains.com/help/resharper/Reference__Code_Inspections_CSHARP.html)

## [Use EditorConfig](https://www.jetbrains.com/help/resharper/Using_EditorConfig.html)

	[inspection_property]=[error | warning | suggestion | hint | none]
