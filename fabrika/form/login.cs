using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabrika.face
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            if(log1.Text == "المدير" && log2.Text == "1")
            {
                mainpage11 x = new mainpage11();
                x.ShowDialog();
            }
            else if (log1.Text == "1" && log2.Text == "1")
            {
                mainpage23 x = new mainpage23();
                x.ShowDialog();
            }
            else
            {
                MessageBox.Show("من فضلك أدخل بيانات صحيحة");
                log1.Focus();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            log1.Focus();
        }

        private void log1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                log2.Focus();
            }
        }

        private void log2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                but1.Focus();
            }
        }
    }
}