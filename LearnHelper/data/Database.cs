using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHelper.data
{
    public class Database
    {

        public ArrayList elementList { get; private set; }

        public Database()
        {
            elementList = new ArrayList();
            // read in files to list
        }

        public void AddElement(string question, string answer, string topic)
        {
            if (question == "" || answer == "" || topic == "")
                throw new DatabaseFailureException("Error, please fill in question, answer and topic");

            if (question.Contains(";") || answer.Contains(";") || topic.Contains(";"))
                throw new DatabaseFailureException("Text cannot contain a semicolon!");

            Element el = new Element(question, answer, topic, elementList.Count + 1);
            elementList.Add(el);
        }

        public void WriteDataToFile()
        {
            string line;

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(@"database.learnhelper"))
            {
                foreach (Element el in elementList)
                {
                    line = el.question + ";" + el.answer + ";" + el.topic;
                    outputFile.WriteLine(line);
                }
            }
        }

        public void ReadDataFromFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("database.learnhelper"))
                {

                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadLine();
                    int i = 1;

                    while (line != null)
                    {
                        string[] splitted = line.Split(';');
                        elementList.Add(new Element(splitted[0], splitted[1], splitted[2], i));
                        line = sr.ReadLine();
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                throw new DatabaseFailureException("Database could not be read");
            }
        }
    }
}
