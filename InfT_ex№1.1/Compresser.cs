using System;
using System.Text;

namespace InfT_ex_1._1
{
    internal static class Compresser
    {
        internal static string Compress(string thisString)
        {
            var charArray = thisString.ToCharArray();
            var newString = new StringBuilder();
            char valueChar = charArray[0];
            var counter = 0;
            for (var i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == valueChar)
                {
                    counter++;
                }
                else
                {
                    newString.Append(valueChar + counter.ToString());
                    valueChar = charArray[i];
                    counter = 1;
                }
            }
            newString.Append(valueChar + counter.ToString());

            return newString.ToString();
        }
    }
}