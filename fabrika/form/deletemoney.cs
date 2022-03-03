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
    public partial class deletemoney : DevExpress.XtraEditors.XtraForm,form.Interface.gardinterface
    {
        logs.Presenter.gardpresenter gar;
         
        public deletemoney()
        {
            InitializeComponent();
            gar = new logs.Presenter.gardpresenter(this);
        }

        public object datagrid { get =>dvg4.DataSource ; set => dvg4.DataSource = value; }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void but8_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void deletemoney_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gar.display();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gar.display2();
        }

        private void but8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}