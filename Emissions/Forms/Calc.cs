using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emissions
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void NextTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ? tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void PrevTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 >= 0) ? tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
        }
    }
}
