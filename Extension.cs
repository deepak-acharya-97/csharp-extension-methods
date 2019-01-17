using System;

namespace ExtensionMethods
{
    public enum Grades
    {
        FF = 0,
        FA = 0,
        DD = 4,
        CD = 5,
        CC = 6,
        BC = 7,
        BB = 8,
        AB = 9,
        AA = 10
    };
    public static class DeepakExtensionMethods
    {
        private static Grades MinGrade;

        static DeepakExtensionMethods()
        {
            MinGrade = Grades.CC;
        }

        public static void UpdateMinimumGrade(Grades grade, string AuthorizationToken)
        {
            if (AuthorizationToken != "Deepak@123")
            {
                Console.WriteLine("Permission Denied");
            }
            else
            {
                MinGrade = grade;
                Console.WriteLine("***MinGrade Updated Successfully***");
            }
        }

        public static bool Passed(this Grades grade)
        {
            return grade >= MinGrade;
        }
    }

}