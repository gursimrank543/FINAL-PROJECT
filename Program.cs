/*
 * Author: Gursimran Kaur
 * Course: COMP003A
 * Purpose: COMP003A.Final Project
 */

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // User input for personal information
            string firstName =("Gursimran");
            string lastName = ("Kaur");
            int birthYear = (2003);
            char gender = ValidateGender();
            // Array to store user responses to questionnaire
            string[] responses = new string[10];
            for (int i = 0; i < responses.Length; i++)
            {
                Console.WriteLine($"Question{i + 1}:");
                responses[i] = Console.ReadLine();
            }
            // Print profile summary

            Console.WriteLine("\nProfile Summary:");
            Console.WriteLine($"Name:{lastName},{firstName}");
            Console.WriteLine($"Age:{DateTime.Now.Year - birthYear}");
            Console.WriteLine($"Gender:{GetGenderDescription(gender)}");
            //Display questionnare responses
            Console.WriteLine("\nQuestionnare Responses:");
            for (int i = 0; i < responses.Length; i++)
            {
                Console.WriteLine($"Question{i + 1}:{responses[i]}");
            }
        }
        /// <summary>
        /// Validates and retrieves the user's first or last name
        /// </summary>
        /// <param name="nameType">Type of name(First or last)</param>
        /// <returns>Vaildated first or last name.</returns>
        static string ValidateName(string nameType)
        {
            string name;
            do
            {
                Console.WriteLine($"Enter{nameType}Name:");
                name = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(name) || !IsNameValid(name));
            return name;
        }
        ///<summary>
        ///Validates the user's birth year.
        ///</summary>
        ///<returns>Vaildated birth year.</returns>
        static int ValidateBirthYear()
        {
            int birthYear;
            do
            {
                Console.WriteLine("Enter Birth Year:");
                birthYear = int.Parse(Console.ReadLine());
            } while (birthYear < 19000 || birthYear > DateTime.Now.Year);
            return birthYear;
        }
        ///<summary>
        ///Validates the user's gender.
        ///</summary>
        ///<returns>Validates gender.</returns>
        static char ValidateGender()
        {
            char gender;
            do
            {
                Console.WriteLine("Enter Gender(F):");
                gender = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (gender != 'M' && gender != 'F' && gender != 'O');
            return gender;
        }
        ///<summary>
        ///Checks if the given name contains only letters and is not empty
        ///</summary>
        ///<param name="name">Name to validate.</param>
        ///<returns>True if the name is valid; otherwise, false.</returns>
        static bool IsNameValid(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        ///<summary>
        ///Gets the full description of the gender based on the provided character
        ///</summary>
        ///<param name="gender">Gender character(M/F/O).</param>
        ///<returns>Full gender description.</returns>
        static string GetGenderDescription(char gender)
        {
            return gender switch
            {
                'M' => "Male",
                'F' => "Female",
                _ => "Other",
            };
        }
    }
}
    
