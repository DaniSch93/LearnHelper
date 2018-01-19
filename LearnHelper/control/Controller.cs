using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnHelper.data;
using System.Windows.Forms;
using LearnHelper;

namespace LearnHelper.control
{
    public class Controller
    {
        public Database data { get; private set;}
        public AddWindow addWin { get; set; }
        public DataList dataList { get; set; }
        private Element curElem;

        public Controller(Database data)
        {
            this.data = data;
        }

        public void Add(string question, string answer, string topic)
        {
            try
            {
                this.data.AddElement(question, answer, topic);
                this.addWin.Close();
                if (this.dataList != null)
                {
                    this.dataList.addToList(topic, question);
                    this.dataList.Refresh();
                }
            }
            catch (NullReferenceException e)
            {
                // do nothing
            }
            catch (DatabaseFailureException e)
            {
                MessageBox.Show("Frage, Antwort und Thema dürfen nicht leer sein und kein Semikolon enthalten!");
            }
            
        }

        public void Remove(string topic, string question)
        {
            this.data.RemoveElement(topic, question);   
        }

        public void CreateAddWindow()
        {
            this.addWin = new AddWindow(this);
        }

        public void CreateDataList()
        {
            this.dataList = new DataList(this);
        }

        public string GetNewQuestion(string topic)
        {
            Random rnd = new Random();

            if (topic.Equals("None"))
            {
                throw new ControlFailureException("topic is empty");
            }


            do
            {
                int number = rnd.Next(1, this.data.elementList.Count);
                curElem = (Element)this.data.elementList[number];
            } while (!curElem.topic.Equals(topic));

            return curElem.question;
        }

        public string ShowAnswer()
        {
            return curElem.answer;
        }

        public string[] getDropdownTopics()
        {
            var topics = new List<String>();

            foreach (Element e in this.data.elementList)
            {
                if (!topics.Contains(e.topic))
                    topics.Add(e.topic);
            }

            return topics.ToArray();
        }
    }
}
