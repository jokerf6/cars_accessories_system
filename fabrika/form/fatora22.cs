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
    public partial class fatora22 : DevExpress.XtraEditors.XtraForm
    {
        public fatora22()
        {
            InitializeComponent();
        }

        private void but9_Click(object sender, EventArgs e)
        {
            //mainpage11 x = new mainpage11();
            //fatora22 y = new fatora22();
            this.Hide();
            //x.ShowDialog();
               this.Close();

        }


        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }
    }
}