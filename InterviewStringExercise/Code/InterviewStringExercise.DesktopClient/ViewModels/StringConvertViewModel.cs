using InterviewStringExercise.Data;
using InterviewStringExercise.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStringExercise.DesktopClient.ViewModels
{
    public class StringConvertViewModel: ObservableObject
    {
        private string inputString;
        private string outputString;
        public StringConvertViewModel()
        {
           
        }
        /// <summary>
        /// Get and set Input String
        /// </summary>
        public string InputString
        {
            get
            {
                return inputString;
            }

            set
            {
                inputString = value;
                NotifyPropertyChanged();
            }
        }
        /// <summary>
        /// Get and set Output String
        /// </summary>
        public string OutputString
        {
            get
            {
                return outputString;
            }

            set
            {
                outputString = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Run this when CovertString button is clicked
        /// </summary>
        public ActionCommand ConvertStringCommand
        {
            get
            {
                return new ActionCommand(p => ConvertString(InputString));
            }
        }
        /// <summary>
        /// Split the input string into individual words by white spaces
        /// </summary>
        /// <param name="input"></param>
        private void ConvertString(string input)
        {
          
            List<Word> orderedList = new List<Word>();
            char[] delimiaterChar = { ' ', '\t' };//determine a new word with any whitespace
            string[] words = InputString.Split(delimiaterChar);//split the words and put into a list

            //determine the position of each words
            foreach (var word in words)
            {
                Word newWord = new Word(word);
                countCharReoccurences(newWord);
                orderedList.Add(newWord);
            }
   
            orderedList =  orderedList.OrderByDescending(o => o.reoccurences).ToList() ;//order the list by most ouccrences
            //output the new string
            foreach (var word in orderedList)
            {
                OutputString += word.text + " ";
            }
            
        }

        private void countCharReoccurences(Word word)
        {
            string text = word.text;
            int count = 0;
            foreach (var character in text)
            {
                int tempCount = 0;
                for (int i = 0; i < text.Length; i++)//check if there are any repeating letter 
                {
                    //int tempCount = 0;
                    if(character == text[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                    count = tempCount;//record reoccurences count
            }
            word.reoccurences = count - 1; //remove the count at the same position (-1)
         
        }
    }
}
