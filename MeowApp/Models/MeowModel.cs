using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeowApp.Models
{
    public class MeowModel
    {
        public static int MeowCount(string inputString)
        {
            string word = "meow";
            string[] text;
            string checkString = "";
            checkString = inputString.Replace('\n', ' ');
            checkString = checkString.Replace('\r', ' ');
            checkString = checkString.ToLower();
            text = checkString.Split(new char[] { ' ' });
            int result = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                if (text[i] == word)
                {
                    result = result + 1;
                }
            }
            return result;
        }
    }
}