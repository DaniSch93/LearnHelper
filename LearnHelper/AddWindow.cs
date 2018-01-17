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

namespace LearnHelper
{
    public partial class AddWindow : Form
    {
        private Controller contr;

        public AddWindow(Controller control)
        {
            InitializeComponent();
            this.contr = control;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.contr.Add(questionBox.Text, answerBox.Text, topicBox.Text);
        }
    }
}
