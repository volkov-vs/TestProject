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
    public partial class MarachevForm : Form
    {
        public MarachevForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
