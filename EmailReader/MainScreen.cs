using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmailReader
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void tagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      private void MainScreen_Load(object sender, EventArgs e)
      {
        Testing.MainTest test= new EmailReader.Testing.MainTest();
      }
    }
}