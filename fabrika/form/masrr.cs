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

namespace fabrika.form
{
    public partial class masrr : DevExpress.XtraEditors.XtraForm ,form.Interface.masrdisplay
    {
        public object datagrid { get => dgv1.DataSource; set => dgv1.DataSource = value; }
        logs.Presenter.displaymasrpresenter dis;
        public masrr()
        {
            InitializeComponent();
          dis = new logs.Presenter.displaymasrpresenter(this);
        }

        private void masr_Load(object sender, EventArgs e)
        {
            dis.getalldata();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}