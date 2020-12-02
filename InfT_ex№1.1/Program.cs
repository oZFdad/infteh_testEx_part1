
using System;
using System.Collections.Generic;

namespace InfT_ex_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = new List<string>();
            stringList.Add("kkkkkkkkkkkddddddjjjjjjjeeeeuuuaahjdkdooooodhhhh");
            stringList.Add("ksjdfyvclzmshfidsfjjjdfpsfdgnsefobmxh");
            stringList.Add("kkeeooohlkffooiiii");
            var compressedStringList = new List<string>();

            foreach(var thisString in stringList)
            {
                compressedStringList.Add(Compresser.Compress(thisString));
            }

            var finishList = SupportClass.CompareThisLists(stringList, compressedStringList);
            SupportClass.Show(finishList);

            Console.ReadKey();
        }
    }
}
