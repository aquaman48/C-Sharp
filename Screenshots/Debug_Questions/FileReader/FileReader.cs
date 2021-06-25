/*
This program computes the average of a student's grades.

The expected output is:
	<increasing line number followed by file text, line by line>

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that 
the program is working as expected.

using System;
using System.IO;

namespace IDL5 {
	public class dumper {
		public static void Main(string[] args) {
			string lines;
			var fileStream = new FileStream(@"c:\windows\win.ini", FileMode.Open, FileAccess.Read);
			using (var streamReader = new StreamReader(fileStream)) {
			    string text = streamReader.ReadToEnd();
			    lines = text.Split('\n');
			}
			int num = 0;
			foreach (string line in lines) {
				Console.WriteLine(num + 1 + ": " + lines[num]);
			}
		}
	}
}

 */

using System;
using System.IO;
using static System.Console;

namespace DeBuggin
{
	public class FileReader
	{
		static void Main(string[] args)
		{

			string[] lines;//make the string an array						   
			var fileStream = new FileStream(@"c:\Users\nswat\Practice.txt", FileMode.Open, FileAccess.Read);
			using (var streamReader = new StreamReader(fileStream))
			{
				string text = streamReader.ReadToEnd();
				lines = text.Split('\n');
			}
			//int num = 0;
			for (int num = 0; num < lines.Length; num++)//change foreach to a for loop to write lines.
			{
				WriteLine(num + 1 + ": " + lines[num]);
			}
		}
	}
}
