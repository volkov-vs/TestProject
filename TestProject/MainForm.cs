using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Forms;

namespace TestProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void VolkovButton_Click(object sender, EventArgs e)
        {
            VolkovForm form = new VolkovForm();
            form.ShowDialog();
        }

        private void NovikovButton_Click(object sender, EventArgs e)
        {
            NovikovForm form = new NovikovForm();
            form.ShowDialog(); 
        }
    }
}
