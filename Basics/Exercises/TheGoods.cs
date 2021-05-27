/*
The expected output is:
The sales for today is 104.90

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that 
the program is working as expected.

*/

using System;
using static System.Console;

namespace IDL1
{
    public class tasties
    {
        public static void Main()
        {
            double numberManufactured = 421;
            double numberPerBox = 12;
            //double boxesSold = numberManufactured % numberPerBox; the Modulus operator was used instead of the division operator
            double boxesSold = numberManufactured / numberPerBox;
            // int costPerBox = 2.99; should be a double data type
            double costPerBox = 2.99;
            double sales = boxesSold * costPerBox;
            // In the write line we can tidy it up to go to only 2 decimal places and a "currency" format.
            WriteLine("The sales for today is " + "{0:c2}",sales);
            // adding ReadKey for personal formatting purposes
            ReadKey();
        }
    }
}
