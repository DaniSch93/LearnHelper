using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using LearnHelper.control;
using LearnHelper.data;

namespace LearnHelper
{
    public partial class DataList : Form
    {
        private Controller contr;
        public DataList(Controller contr)
        {
            InitializeComponent();
            this.contr = contr;
            this.createMyList();
        }

        private void createMyList()
        {
            foreach (Element elem in this.contr.data.elementList)
                this.addToList(elem.topic, elem.question);
        }

        public void addToList(string topic, string question)
        {
            this.listViewData.Items.Add(new ListViewItem(new string[] { topic, question }));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.contr.CreateAddWindow();
            this.contr.addWin.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewData.SelectedItems)
            {
                this.contr.Remove(item.Text, item.SubItems[1].Text);
                item.Remove();
            }

        }

    }
}
