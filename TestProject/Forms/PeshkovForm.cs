using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.Forms
{
    public partial class PeshkovForm : Form
    {
        public PeshkovForm()
        {
            InitializeComponent();
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PeshkovForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
         
           
        }
    }
}
