using System;
using ExtensionMethods;

namespace play_with_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades MyGrade=Grades.AB;
            DeepakExtensionMethods.UpdateMinimumGrade(Grades.AA,"Deepak@321");
            string result=MyGrade.Passed() ? "Passed" : "Failed";
            Console.Write(result);
        }
    }
}
