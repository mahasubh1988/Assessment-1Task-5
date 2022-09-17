using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1Task_5
{
    internal class Program
    {
        // Class Marks definition
        class Marks
        {
            // Math Mark
            public int subjectMath
            {
                get;
                set;
            }

            // Physics Mark
            public int subjectPhysics
            {
                get;
                set;
            }

            // Chemistry Mark
            public int subjectChemistry
            {
                get;
                set;
            }

            // Computer Science Mark
            public int subjectComputerScience
            {
                get;
                set;
            }

            // Student Name
            public string studentName
            {
                get;
                set;
            }

            // Marks Average Method
            public float AverageMarks()
            {
                return (float) (subjectMath + subjectPhysics + subjectChemistry + subjectComputerScience)/4;
            }

            // Student Grade Method
            public char SutdentGrade()
            {
                // Marks average variable
                float average = AverageMarks();

                // Calculate the student grade
                if (80 <= average)
                    return 'A';
                if (70 <= average && average < 80)
                    return 'B';
                if (60 <= average && average < 70)
                    return 'C';
                if (50 <= average && average < 60)
                    return 'D';
                
                return 'F';
            }

            // Method for prinint all marks and the average
            public void PrintMarks()
            {
                Console.WriteLine("sutdentName: {0}, " +
                    "subjectMath: {1}, " +
                    "subjectPhysics: {2}, " +
                    "subjectChemsitry: {3}, " +
                    "subjectComputerScenice: {4}, " +
                    "AverageMarks: {5}",
                    studentName, subjectMath, subjectPhysics,
                    subjectChemistry, subjectComputerScience, AverageMarks());
            }

            // Method for printing the student grade
            public void PrintGrade()
            {
                char grade = SutdentGrade();

                // switch command for printing grade labels
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Excellent! Your grade is A");
                        break;

                    case 'B':
                        Console.WriteLine("Good! Your grade is B");
                        break;

                    case 'C':
                        Console.WriteLine("Satisfactory. Your grade is C");
                        break;

                    case 'D':
                        Console.WriteLine("Pass. Your grade is D");
                        break;

                    case 'F':
                        Console.WriteLine("Fail. Your grade is F");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            // creating stud1 object
            Marks stud1 = new Marks();

            // try-catch for user input exceptions
            try
            {
                // Entering the student name
                Console.Write("Please Enter Student Name: ");
                stud1.studentName = Console.ReadLine();
                
                // Entering and validating Math mark
                Console.Write("Please Enter Subject Math Marks: ");
                stud1.subjectMath = Convert.ToInt32(Console.ReadLine());
                if (stud1.subjectMath < 0 || stud1.subjectMath > 100)
                    throw new ArithmeticException("The mark value is not valid!");

                // Entering and validating Physics mark
                Console.Write("Please Enter Subject Physics Marks: ");
                stud1.subjectPhysics = Convert.ToInt32(Console.ReadLine());
                if (stud1.subjectPhysics < 0 || stud1.subjectPhysics > 100)
                    throw new ArithmeticException("The mark value is not valid!");

                // Entering and validating Chemistry mark
                Console.Write("Please Enter Subject Chemistry Marks: ");
                stud1.subjectChemistry = Convert.ToInt32(Console.ReadLine());
                if (stud1.subjectChemistry < 0 || stud1.subjectChemistry > 100)
                    throw new ArithmeticException("The mark value is not valid!");

                // Entering and validating Computer science mark
                Console.Write("Please Enter Subject Computer Science Marks: ");
                stud1.subjectComputerScience = Convert.ToInt32(Console.ReadLine());
                if (stud1.subjectComputerScience < 0 || stud1.subjectComputerScience > 100)
                    throw new ArithmeticException("The mark Value is not valid!");
            }
            catch (Exception e)
            {
                // Printing the error message and ending the program
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            // Printing the student's marks
            stud1.PrintMarks();

            // Prinint the sudent's grade
            stud1.PrintGrade();

            Console.ReadLine();
        }
    }
}
