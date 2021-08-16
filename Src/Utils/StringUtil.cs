using System;
using System.Reflection.Metadata.Ecma335;

namespace CrashCourse2021ExercisesDayOne.Utils
{
    internal class StringUtil
    {
        internal int LengthOfString(string stringToMeasure)
        {
            if (stringToMeasure == null)
            {
                throw new NullReferenceException(Constants.StringCannotBeNull);
            }
            else
            {
                return stringToMeasure.Length;
            }

            throw new NotImplementedException();
        }

        internal string SumStrings(string value1, string value2)
        {
            int sum = Int32.Parse(value1) + Int32.Parse(value2);

            return sum.ToString();
            
            throw new NotImplementedException();
        }

        internal string DivideString(string value1, string value2)
        {
            
            int sum = Int32.Parse(value1) / Int32.Parse(value2);

            return sum.ToString();
            
            throw new NotImplementedException();
        }

        internal string StringContains(string value1, string value2)
        {
            var yes = "YES";
            var no = "NO";    
            
            if (value1.Contains(value2))
            {
                return yes;
            }
            else
            {
                return no;
            }
            
            throw new NotImplementedException();
        }

        internal string StringToUpperCase(string value1)
        {
            return value1.ToUpper();
            
            throw new NotImplementedException();
        }

        internal string AdditionFromPlusString(string inputString)
        {
            string[] talList = inputString.Split('+');

            int sum = 0;

            foreach (var tal in talList)
            {
                sum += Int32.Parse(tal);
            }

            return sum.ToString();
            
            throw new NotImplementedException();
        }

        internal string EvenNumber(int numbertoTest)
        {
            if (numbertoTest % 2 == 0)
            {
                return Utils.Constants.Even;
            }
            else
            {
                return Utils.Constants.Odd;
            }
            
            throw new NotImplementedException();
        }
    }
}