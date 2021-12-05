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
    }
}
