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

        private void PeshkovButton_Click(object sender, EventArgs e)
        {
            PeshkovForm form = new PeshkovForm();
            form.ShowDialog();
        }

        
    }
}
