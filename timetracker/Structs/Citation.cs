using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Structs
{
    class Citation
    {
        public string Author;
        public string Words;

        public Citation(string author, string words)
        {
            Author = author;
            Words = words;
        }
    }
}
