using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.Step7
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static string NameIterator()
        {
            string names = string.Join(", ", NamesList);
            return names;
        }

        public static object TESTModule(object x)
        {
            switch(x)
            {
                case int i when i < 1:
                    throw new ArgumentOutOfRangeException();

                case int i when i <= 4:
                    i *= 2;
                    return i;

                case int i when i > 4:
                    i *= 3;
                    return i;

                case 1.0f:
                case 2.0f:
                    return 3.0f;

                case string y:
                    return y.ToUpper();

                default:
                    return x;
            }
        }
    }
}
