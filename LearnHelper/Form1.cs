using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LearnHelper.data;
using LearnHelper.control;

namespace LearnHelper
{
    public partial class MainWindow : Form
    {
        private Database datab;
        private Controller control;

        public MainWindow()
        {
            InitializeComponent();
            datab = new Database();
            control = new Controller(this.datab);
            setDropdownTopics();
        }

        private void setDropdownTopics()
        {
            foreach (string s in this.control.getDropdownTopics())
                comboBoxTopics.Items.Add(s);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.control.CreateAddWindow();
            this.control.addWin.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            datab.WriteDataToFile();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.control.CreateDataList();
            this.control.dataList.Show();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            // reset Answer Box
            textBoxAnswer.Text = "";
            try
            {
                textBoxQuestion.Text = this.control.GetNewQuestion(comboBoxTopics.Text);
            }
            catch (ControlFailureException ex)
            {
                MessageBox.Show("Please choose a topic");
            }
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = this.control.ShowAnswer();
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            // only increment when answer is shown and text box not empty
            if (textBoxQuestion.Text != "" && textBoxAnswer.Text != "")
            {
                int i = Convert.ToInt32(labelCorrect.Text);
                i++;
                labelCorrect.Text = Convert.ToString(i);

                textBoxAnswer.Text = "";
                try
                {
                    textBoxQuestion.Text = this.control.GetNewQuestion(comboBoxTopics.Text);
                }
                catch(ControlFailureException ex)
                {
                    MessageBox.Show("Please choose a topic");
                }
                
            }
        }

        private void buttonIncorrect_Click(object sender, EventArgs e)
        {
            // only increment when answer is shown and text box not empty
            if (textBoxQuestion.Text != "" && textBoxAnswer.Text != "")
            {
                int i = Convert.ToInt32(labelIncorrect.Text);
                i++;
                labelIncorrect.Text = Convert.ToString(i);

                textBoxAnswer.Text = "";
                try
                {
                    textBoxQuestion.Text = this.control.GetNewQuestion(comboBoxTopics.Text);
                } 
                catch (ControlFailureException ex)
                {
                    MessageBox.Show("Please choose a topic");
                }

                
            }
        }
    }
}
