using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppp
{
    public class Student
    {
        private string studentNumber;
        private string studentLastName;
        private string studentFirstName;
        private int score1;
        private int score2;
        private int score3;
        private string major;

        // Default Constructor
        public Student()
        {

        }

        //Constructor with one parameter
        public Student(string sID)
        {
            studentNumber = sID;
        }
        
        //Constructor with three parameters
        public Student(string sID, string firstName, string lastName)
        {
            studentNumber = sID;
            studentFirstName = firstName;
            studentLastName = lastName;
        }

        //Constructor for all data members
        public Student(string sID, string firstName, string lastName,
                        int s1, int s2, int s3, string maj)
        {
            studentNumber = sID;
            studentFirstName = firstName;
            studentLastName = lastName;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major = maj;
        }

        //Properties
        public string StudentLastName
        {
            get
            {
                return studentLastName;
            }
            set
            {
                studentLastName = value;
            }
        }
        public string StudentFirstName
        {
            get
            {
                return studentFirstName;
            }
            set
            {
                studentFirstName = value;
            }
        }
        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public int Score1
        {
            get
            {
                return score1;
            }
            set
            {
                score1 = value;
            }
        }

        public int Score2
        {
            get
            {
                return score2;
            }
            set
            {
                score2 = value;
            }
        }

        public int Score3
        {
            get
            {
                return score3;
            }
            set
            {
                score3 = value;
            }
        }

        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public override string ToString()
        {
            return "Name: " + studentFirstName + " " + studentLastName + 
                    "\nMajor: " + major + "\nScore Average: " + 
                    CalculateAverage().ToString("F2");


        }
    }
}
