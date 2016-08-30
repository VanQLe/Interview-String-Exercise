using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStringExercise.Data
{
    public class Word
    {
        public string text { get; set;}
        public int reoccurences { get; set; }

        public Word(string word)
        {
            this.text = word;
        }
    }
}
