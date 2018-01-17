using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHelper.data
{
    public class Element
    {

        public string question { get; set; }
        public string answer { get; set; }
        public string topic { get; set; }

        public Element()
        {
            this.question = "NONE";
            this.answer = "NONE";
            this.topic = "NONE";
        }

        public Element(string question, string answer, string topic)
        {
            this.question = question;
            this.answer = answer;
            this.topic = topic;
        }


    }
}
