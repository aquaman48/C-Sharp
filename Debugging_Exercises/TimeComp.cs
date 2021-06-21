/*
    Many businesses need to determine the amount of time that has passed between events.
    These durations are measured in elapsed seconds, and the values can be large.  However,
    humans cannot easily understand times in these units.  Conversion between seconds and
    the more standard hours, minutes, and seconds is therefore necessary.

    Assume that a previous programmer wrote this code, but before debugging and delivering
    it, was transferred to a new department.  Your task to finish the work.  The code is
    almost correct, but compilation (syntax), coding (specification), or output (semantic)
    bugs exist.

    Carefully study the code, determine the problem, and fix the bug or bugs so that the
    output is as expected.  Change as little code as possible to correct the problem.
    Place a comment on or before the fixed lines explaining what is wrong and how the fix
    resolves the issue--no comment(s), no points.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FindingError
{
    class TimeComp
    {
        static void Compute(int duration, out int hours, out int minutes, out int seconds)
        {
            /*
            hours = duration % 60 * 60;  // how many hours?
            duration -= hours * 60 * 60;  // subtract the hours
            minutes = duration % 60;  // how many minutes?
            duration -= duration * 60;  // subtract the minutes
            seconds = duration;

            I will rewrite all these variables.
            */

            seconds = duration % 60; //seconds
            hours = duration / 60; //first part of hours
            minutes = hours % 60; //minutes
            hours = hours / 60; //final hour variable

        }

        static void Main(string[] args)
        {
            int duration = 12345;  // in seconds
            int seconds;
            int minutes;
            int hours;
            WriteLine("12345 seconds is 3 hours, 25 minutes, and 45 seconds");
            Compute(duration, out hours, out minutes, out seconds);
            WriteLine("{0} seconds is {1} hours, {2} minutes, and {3} seconds",
                duration, hours, minutes, seconds);
        }
    }
}
