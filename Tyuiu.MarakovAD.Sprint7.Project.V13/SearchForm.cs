using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonSearchCancel_MAD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchOK_MAD_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}
