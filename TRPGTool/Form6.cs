using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPGTool
{
    public partial class ConsoleForm : Form
    {
        public Form1 parentForm;
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void Console_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            parentForm.コンソールCToolStripMenuItem.Checked = false;
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            listBox1.Items.AddRange(parentForm.notifications);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
