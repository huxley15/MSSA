using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {
                callMenu();
                Console.WriteLine("Would you like to select a different operation? y/n");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Have an awesome day :o) Press enter to exit!");
            Console.ReadLine();
        }
        static void callMenu()
        {
            Console.WriteLine("What operation operation would you like to perform today? Please enter the corresponding number.");
            Console.WriteLine("1: Convert minutes into seconds.");
            Console.WriteLine("2: Calculate the area of a triangle.");
            Console.WriteLine("3: Determine if the sum of two numbers is less than 100.");
            Console.WriteLine("4: Determine if an input is a palindrome.");
            Console.WriteLine("5: Flip the casing of your inputted string.");
            Console.WriteLine("6: Check if a number is even or odd.");
            Console.WriteLine("7: Input student info and determine overall average grade.");
            Console.WriteLine("8: Determine the min and max numbers in an array.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("This function allows you to convert minutes into seconds!");
                    char choice1 = 'y';
                    while (choice1 == 'y' || choice1 == 'Y')
                    {
                        Console.WriteLine("Please enter the number of minutes you would like converted into seconds:");
                        int min = Int32.Parse(Console.ReadLine());
                        int result = convertMinToSec(min);
                        Console.WriteLine($"{min} minutes converts to {result} seconds");
                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice1 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "2":
                    Console.WriteLine("This function calculates the area of a triangle!");
                    char choice2 = 'y';
                    while (choice2 == 'y' || choice2 == 'Y')
                    {
                        Console.WriteLine("Please enter the base of the triangle:");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the height of your triangle:");
                        double num2 = double.Parse(Console.ReadLine());
                        double result = areaTriangle(num1, num2);
                        Console.WriteLine($"The area of a triangle with a base of {num1} and a height of {num2} is {result}!");
                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice2 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "3":
                    Console.WriteLine("This function determines if the sum of two numbers is less than 100!");
                    char choice3 = 'y';
                    while (choice3 == 'y' || choice3 == 'Y')
                    {
                        Console.WriteLine("Please enter the first number:");
                        int num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the second number:");
                        int num2 = Int32.Parse(Console.ReadLine());
                        int result = sum(num1, num2);
                        if (result > 100)
                        {
                            Console.WriteLine($"The sum of {num1} and {num2} is {result}, which is NOT less than 100!");
                        }
                        else if (result == 100)
                        {
                            Console.WriteLine($"The sum of {num1} and {num2} is {result}, which is EQUAL TO 100!");
                        }
                        else if (result < 100)
                        {
                            Console.WriteLine($"The sum of {num1} and {num2} is {result}, which is LESS THAN 100!");
                        }
                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice3 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "4":
                    Console.WriteLine("This function determines if an input is a palindrome!");
                    char choice4 = 'y';
                    while (choice4 == 'y' || choice4 == 'Y')
                    {
                        string palindromeInput = "";
                        bool result;
                        Console.WriteLine("Enter text that you would like to be checked as to whether it is a palindrome or not.");
                        Console.WriteLine("Result will return true if it is a palindrome, or false if not.");
                        Console.WriteLine("Input text now:");
                        palindromeInput = Console.ReadLine();
                        result = isPalindrome(palindromeInput);
                        Console.WriteLine($"Input is palindrome = {result}");
                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice4 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "5":
                    Console.WriteLine("This function flips the casing of your input letters!");
                    char choice5 = 'y';
                    while (choice5 == 'y' || choice5 == 'Y')
                    {
                        string caseString;
                        char[] caseArray;
                        int l, i;
                        l = 0;
                        char caseChar;
                        Console.WriteLine("Enter the string you would like to have the casing flipped for:");
                        caseString = Console.ReadLine();
                        l = caseString.Length;
                        caseArray = caseString.ToCharArray(0, l); //converts the string into a char array
                        Console.WriteLine("After case conversion, your input becomes: ");
                        for (i = 0; i < l; i++)
                        {
                            caseChar = caseArray[i];
                            if (Char.IsLower(caseChar))
                            {
                                Console.Write(Char.ToUpper(caseChar)); //converts lowercase char to upper case
                            }
                            else
                            {
                                Console.Write(Char.ToLower(caseChar)); //converts uppercase char to lower case
                            }
                        }
                        Console.Write("\n");
                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice5 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "6":
                    Console.WriteLine("This function checks if a number is even or odd!");
                    char choice6 = 'y';
                    while (choice6 == 'y' || choice6 == 'Y')
                    {
                        int numInput;
                        Console.WriteLine("Please enter the number you would like to be checked as even or odd:");
                        numInput = Int32.Parse(Console.ReadLine());
                        if (numInput % 2 == 0)
                        {
                            Console.WriteLine($"{numInput} is an even number!");
                        }
                        else
                        {
                            Console.WriteLine($"{numInput} is an odd number!");
                        }

                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice6 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "7":
                    Console.WriteLine("This function takes student info and provides the overall grade and division!");
                    char choice7 = 'y';
                    while (choice7 == 'y' || choice7 == 'Y')
                    {
                        int studentRoll, physGrade, chemGrade, compGrade;
                        double totalGrade;
                        double percentGrade;
                        string studentName, studentDivision;
                        Console.WriteLine("Enter the student's roll number:");
                        studentRoll = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the student's name:");
                        studentName = Console.ReadLine();
                        Console.WriteLine($"Enter {studentName}'s Physics grade:");
                        physGrade = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter {studentName}'s Chemistry grade:");
                        chemGrade = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter {studentName}'s Computer Application grade:");
                        compGrade = Int32.Parse(Console.ReadLine());
                        totalGrade = physGrade + chemGrade + compGrade;
                        percentGrade = totalGrade / 3.0;
                        if (percentGrade >= 75)
                        {
                            studentDivision = "Distinctive";
                        }
                        else if (percentGrade < 75 && percentGrade >= 60)
                        {
                            studentDivision = "First Class";
                        }
                        else if (percentGrade < 60 && percentGrade >= 50)
                        {
                            studentDivision = "Second Class";
                        }
                        else if (percentGrade < 50 && percentGrade >= 40)
                        {
                            studentDivision = "Passing";
                        }
                        else
                        {
                            studentDivision = "Failing";
                        }
                        Console.WriteLine("Roll Number: {0}", studentRoll);
                        Console.WriteLine($"Student name: {studentName}");
                        Console.WriteLine($"Marks in Physics: {physGrade}");
                        Console.WriteLine($"Marks in Chemistry: {chemGrade}");
                        Console.WriteLine($"Marks in Computer Application: {compGrade}");
                        Console.WriteLine($"Total marks: {totalGrade}");
                        Console.WriteLine($"Percentage: {percentGrade}%");
                        Console.WriteLine($"Division: {studentDivision}");

                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice7 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
                case "8":
                    Console.WriteLine("This function determines the minimum and maximum values within an array!");
                    char choice8 = 'y';
                    while (choice8 == 'y' || choice8 == 'Y')
                    {
                        int[] array1 = new int[100];
                        int i, min, max, elements;
                        Console.WriteLine("Enter the number of elements to be stored in the array:");
                        elements = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter {elements} numbers to be placed into the array:");
                        for (i = 0; i < elements; i++)
                        {
                            Console.WriteLine($"Element - {i}:");
                            array1[i] = Int32.Parse(Console.ReadLine());
                        }
                        max = array1[0];
                        min = array1[0];
                        for (i = 1; i < elements; i++)
                        {
                            if (array1[i] > max)
                            {
                                max = array1[i];
                            }
                            if (array1[i] < min)
                            {
                                min = array1[i];
                            }
                        }
                        Console.WriteLine($"Minimum element is: {min}");
                        Console.WriteLine($"Maximum element is: {max}");

                        Console.WriteLine("Would you like to perform this again? y/n");
                        choice8 = Convert.ToChar(Console.ReadLine());
                    }
                    break;
            }
        }
        static int convertMinToSec(int num1)
        {
            return num1 * 60;
        }
        static double areaTriangle(double num1, double num2)
        {
            return (num1 * num2) / 2;
        }
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static bool isPalindrome(string string1)
        {
            string string2;
            string2 = string1.ToUpper(); //convert the input to upper case
            var sb = new StringBuilder(); //use a stringbuilder to strip out punctuation
            foreach (char c in string2) //add characters to builder if not punctuaton or white space
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            string2 = sb.ToString(); //convert builder to the finished string
            int i = 0, j = string2.Length - 1; //compare characters at beginning and end of string
            while (i <= j)
            {
                if (string2[i] != string2[j]) //if the character at each index does not match, it's not a palindrome
                {
                    return (false);
                }
                i++; //update counters and try again
                j--;
            }
            return (true); //if this point is reached, input is a palindrome
        }
        
    }
}
