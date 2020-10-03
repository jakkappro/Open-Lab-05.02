using System;
using System.Runtime.InteropServices;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            string ret = "";

            if(sentence.Contains("!"))
            {
                removeChar(sentence, '!', out ret);
                return ret + "!";
            }

            if(sentence.Contains("?"))
            {
                removeChar(sentence, '?', out ret);
                return ret + "?";
            }

            return sentence;
        }

        void removeChar(String str, char remove, out string stri)
        {
            if(str[str.Length - 1] == remove)
            {
                
                removeChar(str.Substring(0, str.Length - 1), remove, out stri);
            }
            else
            {
                stri = str.Substring(0, str.Length); 
            }
            
        }
    }
}
