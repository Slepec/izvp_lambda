using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_lambda
{
    public class Question
    {
        private string question;
        private string answer;

        public Question(string question, string answer)
        {
            this.QUestion = question;
            this.Answer = answer;
        }

        public string QUestion { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}
