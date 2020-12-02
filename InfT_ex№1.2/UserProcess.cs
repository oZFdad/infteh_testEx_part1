using System;
using System.Collections.Generic;

namespace InfT_ex_1._2
{
    internal class UserProcess
    {
        private int [] _userArray;
        private readonly List<int> _magicValueList = new List<int>();

        internal UserProcess(int[] userArray)
        {
            _userArray = userArray;
        }

        internal void Start()
        {
            var maxCounter = _userArray.Length - 1;

            for(var i = 0; i <= maxCounter; i++)
            {
                if (_userArray[i] > maxCounter)
                {
                    break;
                }
                if (_userArray[i] == i)
                {
                    _magicValueList.Add(i);
                }
            }

            Display();
        }

        private void Display()
        {
            if (_magicValueList.Count == 0)
            {
                Console.WriteLine("нет магических чисел");
            }
            else
            {
                Console.Write("В массиве есть такие магические числа, это: ");
                foreach(var magicValue in _magicValueList)
                {
                    Console.Write($"{magicValue} ");
                }
            }
        }
    }
}