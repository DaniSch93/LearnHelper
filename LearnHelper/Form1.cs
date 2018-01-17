﻿using System;
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

            if (File.Exists("database.learnhelper"))
                this.datab.ReadDataFromFile();
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
    }
}
