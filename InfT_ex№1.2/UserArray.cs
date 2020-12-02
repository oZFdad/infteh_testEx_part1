using System;

namespace InfT_ex_1._2
{
    internal static class UserArray
    {
        private static int _arrayLength = 100; // n из задачи
        private static int _upperRange = 100; // верхний диапозон чисел, в задаче не указан
        internal static int[] CreatArray()
        {
            var rnd = new Random();
            var array = new int[_arrayLength];

            for(var i = 0; i < _arrayLength; ++i)
            {
                array[i] = rnd.Next(_upperRange);
            }

            Array.Sort(array);

            return array;
        }
    }
}