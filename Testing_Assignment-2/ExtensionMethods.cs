using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Assignment_2
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// indicates whether the string provided can be converted to an integer
        /// </summary>
        /// <param name="input">String input parameter</param>
        /// <returns>'Success' if the string can be converted</returns>
        public static string IntegerConverter(this string inputString)
        {
            try
            {
                return "" + int.Parse(inputString);
            }
            catch (Exception)
            {

                return "null";
            }

        }

        /// <summary>
        /// counts the word from given inputstring
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string WordCount(this string inputString)
        {
            int wordCount = 0;
            for (var i = 0; i < inputString.Length; i++)
                if (inputString[i] == ' ' || i == inputString.Length - 1)
                    wordCount++;
            return wordCount.ToString();
        }


        /// <summary>
        /// This function removes the last character from given the inputstring
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string CharacterRemoval(this string inputString)
        {
            return inputString.Substring(0, inputString.Length - 1);
        }

        /// <summary>
        /// Function to identify whether given input string can be converted to a valid numeric value or not.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ConverterCheck(this string inputString)
        {
            try
            {
                int x = int.Parse(inputString);
                return "Success";
            }
            catch (Exception)
            {

                return "Failed";
            }
        }

        /// <summary>
        /// Finds if all the characters from given input string are in upper case or not
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string UpperCaseChecker(this string inputString)
        {
            bool result = true;
            foreach (var character in inputString)
            {
                if (char.IsLower(character))
                {
                    result = false;
                    break;
                }
                else if (char.IsUpper(character))
                {
                    continue;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                return "upparCase";
            }
            return "Failed";
        }

        /// <summary>
        /// Returns a capitalized version of given input string 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>

        public static string CapitalizedCaseConverter(this string inputString)
        {
            TextInfo textInfo = new CultureInfo("en-us", false).TextInfo;
            return textInfo.ToTitleCase(inputString);
        }



        /// <summary>
        /// Finds if all the characters from given input string are in lower case or not
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>

        public static string LowerCaseChecker(this string inputString)
        {
            int ascii = 0;
            foreach (var item in inputString)
            {
                ascii = (int)item;
                bool status = false;
                if (ascii >= 97 && ascii <= 122)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                if (status)
                {
                    return "lowerCase";
                }
            }
            return null;
           
        }

        /// <summary>
        /// Converts the specified inputstring to title case 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string TitleCaseConversion(this string inputString)
        {
            TextInfo textInfo = new CultureInfo("en-us", false).TextInfo;
            return textInfo.ToTitleCase(inputString);
        }

        /// <summary>
        /// Converts uppercase to lowercase and vice vesa
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ViceVersaConverter(this string inputString)
        {
            string output = "";
            int ascii = 0;

            foreach (var ch in inputString)
            {
                ascii = (int)ch;
                if (ascii >= 65 && ascii <= 90)
                    ascii += 32;
                else if (ascii >= 97 && ascii <= 122)
                    ascii -= 32;
                output += (char)ascii;
            }
            return output;

        }


    }
}