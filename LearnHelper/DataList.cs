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
            foreach (Element item in this.contr.data.elementList)
                listBoxData.Items.Add(item.question + "    ;    " + item.topic);
        }

    }
}
