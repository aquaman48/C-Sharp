using System;
using static System.Console;
namespace StudentAppp
{
    class StudentAppp
    {
        static void Main(string[] args)
        {
            // Use the Student class from Student.cs
            Student firstStudentObject = new Student();
            firstStudentObject.StudentFirstName = AskForStudentName("First");
            firstStudentObject.StudentLastName = AskForStudentName("Last");
            firstStudentObject.StudentNumber = AskForStudentNumber();
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);

            firstStudentObject.Score1 = AskForExamScore(1);
            firstStudentObject.Score2 = AskForExamScore(2);
            firstStudentObject.Score3 = AskForExamScore(3);

            Clear();
            WriteLine("First Student");
            WriteLine(firstStudentObject.ToString());

            //Initiating secondStudentObject with predefined parameters of number and scores. Constructor with 1 argument
            Student secondStudentObject = new Student("2345");
            secondStudentObject.Score1 = 95;
            secondStudentObject.Score2 = 62;
            secondStudentObject.Score3 = 87;
            WriteLine("\n\nSecond Student");
            WriteLine("Student Number: " + secondStudentObject.StudentNumber +
                        "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());

            //Initiating thirdStudentObject with predefined parameters of number, last/first name, and scores. Constructor with 3 arguments
            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Score1 = 95;
            thirdStudentObject.Score2 = 87;
            thirdStudentObject.Score3 = 72;
            WriteLine("\n\nThird Student");
            WriteLine(thirdStudentObject);

            //Initiating aStudentObject, Constructor for all arguments and data types. 
            Student aStudentObject = new Student("1234", "Maria", "Smith",
                                                  97, 75, 87, "CS");
            WriteLine("\n\nLast Student");
            WriteLine("Student Name: " + aStudentObject.StudentFirstName + " " +
                        aStudentObject.StudentLastName + "\nStudent Number: " +
                        aStudentObject.StudentNumber + "\nMajor: " + aStudentObject.Major +
                        "\nExam Score 1: " + aStudentObject.Score1 +
                        "\nExam Score 2: " + aStudentObject.Score2 +
                        "\nExam Score 3: " + aStudentObject.Score3 +
                        "\nExam Average: " + aStudentObject.CalculateAverage().ToString("F1"));
            ReadKey();

        }

        static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Write("Enter a value for Score {0}: ", whichOne);
            inValue = ReadLine();
            aScore = int.Parse(inValue);
            return aScore;
        }

        static string AskForStudentName(string whichOne)
        {
            string inValue;
            Write("Enter Student {0} Name: ", whichOne);
            inValue = ReadLine();
            return inValue;
        }

        static string AskForMajor(string name)
        {
            string inValue;
            Write("Enter {0}\'s Major: ", name);
            inValue = ReadLine();
            return inValue;
        }
        
        static string AskForStudentNumber()
        {
            string inValue;
            Write("Enter Student Number: ");
            inValue = ReadLine();
            return inValue;
        }
    }
}
