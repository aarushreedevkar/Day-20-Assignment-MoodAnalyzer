using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalayzerProblems1
{
   public class MoodAnalyser
    {
        
        string message;

        
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

       
        public string Analyser()
        {
            if (this.message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return " sad";
            }
        }

    }
}

