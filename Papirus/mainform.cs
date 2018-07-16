using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Papirus
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            FormLogin main = this.Owner as FormLogin;
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void соцПедХарактеристикаУчебнойГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void картаПерсонифицированногоУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
