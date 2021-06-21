/*
This program computes the average of a student's grades.

The expected output is:
	The average score is <something valid based on input>

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that 
the program is working as expected.

 

using System;

namespace IDL4 {
	public class scores {
		public static void main(string[] args) {
			int count = 0;
			int total = 0;
			do {
				Console.Write("Input score (negative value to quit): ");
				int score = int.Parse(Console.ReadLine());
				if (score < 0)
					break;
				total = score;
				++count;
			} while(true);
			Console.WriteLine("The average score is " + total / count);
		}
	}
}

*/

using System;
using static System.Console; //added for less typing in writeline()

namespace FindingError
{
   public class Scores
    {
        static void Main(string[] args)
        {
			int count = 0;
			int total = 0;
			do
			{
				Write("Input score (00 value to quit): ");
				int score = int.Parse(ReadLine());
				count++;
				if (score == 00)
					break;
				total += score;
				//++count;
			} while (count > 0);
			WriteLine("The average score is " + total / (count - 1));
		}
    }
}
