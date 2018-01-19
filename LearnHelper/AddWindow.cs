using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearnHelper.control;
using LearnHelper.data;

namespace LearnHelper
{
    public partial class AddWindow : Form
    {
        private Controller contr;

        public AddWindow(Controller control)
        {
            InitializeComponent();
            this.contr = control;
            setDropdownTopics();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.contr.Add(questionBox.Text, answerBox.Text, comboBoxTopic.Text);
        }

        private void setDropdownTopics()
        {
            foreach (string s in this.contr.getDropdownTopics())
                comboBoxTopic.Items.Add(s);
        }
    }
}
