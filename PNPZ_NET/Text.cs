using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PNPZ_NET
{
    class Text
    {
        public static string[] SeparatedLine(string line)
        {   //separating words from line

            int spaces = 0;               //counting spaces
            for (int i = 0; i < line.Length; i++)
                if (line[i] == ' ')
                    spaces++;

            int words = spaces + 1;       //amount of words in line
            
            string[] cutline = new string[words];   //returned tab of words

            string tmpwrd = ""; //temporary word variable
            int j = 0;
            for (int i = 0; i < line.Length; i++)
            {  //filling up table with words
                if ((line[i]) != ' ')   //if it's not space, add character to temporary word
                    tmpwrd = tmpwrd + line[i];
                else
                { 
                    cutline[j] = tmpwrd;   //else, add temporary word to current position in tab of words 
                    tmpwrd = "";    //clean temporary word
                    j++;    //next word in tab
                }

            }
            cutline[j] = tmpwrd;    //last word if there's no space
           
            return cutline;
        }

        public static string GetLineFromClipBoard()
        {   //get line in string from clipboard
            var textFromClipBoard = Clipboard.GetText();    //get data from clipboard
            var firstLine = textFromClipBoard.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) //convert data into string
                .First();
            return firstLine;
        }

        public static string WordsAmount (string[] words, int count,int iterator)
        { //make line with specified amount of words
            string output=""; //returned string

            for (int i = iterator; i < iterator + count; i++)   
            {
                if (i >= words.Length) //clean and break if there's no more words
                {
                    output = "";
                    break;
                }
                else      //else, add word to line
                    output += words[i] + " ";
            }
            return output;
        }
    }
}
