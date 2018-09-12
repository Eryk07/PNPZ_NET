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
        public struct cut_line { public string[] words; public int count; };
        //string line(string filename)
        //{ //display one line
        //    ifstream file(filename.c_str()); //open file
        //    string line;

        //    if (!file.is_open())
        //        return NULL;        //if file doesn't exist

        //    if (file.eof())
        //        return NULL;        //if there's no more words

        //    getline(file, line);

        //    file.close();
        //    return line;
        //}

        //int lenght(string inputline)
        //{  //measure line length ->cause .length() and .size() weren't working xD
        //    int i = 0;

        //    do
        //    {

        //        if ((inputline[i]) !=null)
        //            i++;

        //    } while ((inputline[i]) !=null);

        //    return i;
        //}

        public static cut_line separated_line(string line)
        {   //separating word from line

            int spaces = 0;               //counting spaces
            for (int i = 0; i < line.Length; i++)
                if (line[i] == ' ')
                    spaces++;

            int words = spaces + 1;       //amount of words in line
            cut_line output = new cut_line();

            string[] cutline = new string[words];

            string tmp = "";
            int j = 0;
            for (int i = 0; i < line.Length; i++)
            {  //filling up table with words
                if ((line[i]) != ' ')
                    tmp = tmp + line[i];
                else
                {
                    cutline[j] = tmp;
                    tmp = "";
                    j++;
                }

            }
            cutline[j] = tmp;

            output.words = cutline;
            output.count = words;

            return output;
        }

        //void displaying(string filename)
        //{  // display text
        //    ifstream file(filename.c_str());
        //    string line1;
        //    int time = 500; //millisecond
        //    if (!file.is_open())
        //        cout << "there is no such a file or directory \n";      //if file doesn't exist

        //    else if (file.eof())
        //        cout << "file is empty";

        //    else
        //        do
        //        {
        //            getline(file, line1);
        //            cut_line input = separated_line(line1);

        //            string* table = input.line;
        //            int N = input.words;

        //            for (int i = 0; i < N; i++)
        //            {
        //                cout << table[i] << endl;
        //                Sleep(time);
        //                system("cls");
        //            }
        //            delete[] input.line;
        //        } while (!(file.eof()));

        //    file.close();
        //}

        public string GetLineFromClipBoard()
        {
            var textFromClipBoard = Clipboard.GetText();
            var firstLine = textFromClipBoard.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .First();
            return firstLine;
        }
    }
}
