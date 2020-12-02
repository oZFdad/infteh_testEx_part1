using System;

namespace InfT_ex_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var userArray = UserArray.CreatArray();
            var process = new UserProcess(userArray);
            process.Start();
            Console.ReadKey();
        }
    }

    
}
