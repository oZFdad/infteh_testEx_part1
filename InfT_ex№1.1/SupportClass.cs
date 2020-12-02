using System;
using System.Collections.Generic;

namespace InfT_ex_1._1
{
    internal static class SupportClass
    {
        internal static List<string> CompareThisLists(List<string> stringList, List<string> compressedStringList)
        {
            var returnedList = new List<string>();

            for (var i = 0; i < stringList.Count; i++)
            {
                if(stringList[i].Length < compressedStringList[i].Length)
                {
                    returnedList.Add(stringList[i]);
                }
                else
                {
                    returnedList.Add(compressedStringList[i]);
                }
            }

            return returnedList;
        }

        internal static void Show(List<string> finishList)
        {
            foreach(var thisString in finishList)
            {
                Console.WriteLine(thisString);
            }
        }
    }
}