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
    public partial class fatora11 : DevExpress.XtraEditors.XtraForm , form.Interface.fatora11interface 
    {
        public object datagrid { get => dvg5.DataSource; set => dvg5.DataSource =value; }
        public int row { get =>Convert.ToInt32(fk.Text) ; set => fk.Text = value.ToString(); }
        public DateTime date { get =>Convert.ToDateTime(label8.Text); set => label8.Text = value.ToString("yyy / MM / dd"); }
        public decimal dis { get =>Convert.ToDecimal(ft5.Text); set => ft5.Text = value.ToString(); }
        public decimal final { get =>Convert.ToDecimal(ft6.Text); set => ft6.Text = value.ToString(); }
        public int number { get => Convert.ToInt32(ft1.Text); set => ft1.Text = value.ToString(); }
        logs.Presenter.fatora11presenter fpre;
        public fatora11()
        {
            InitializeComponent();
            fpre = new logs.Presenter.fatora11presenter(this);
        }

        private void but8_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void fatora11_Load(object sender, EventArgs e)
        {
            if(fpre.number() == 0)
            {
                start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;
            }
            else
            {
                fpre.number();
                start2.Enabled = true;
                start3.Enabled = true;
                start4.Enabled = true;
                start5.Enabled = true;
            }
            row = 0;
            fpre.data();
        }

        private void f3_TextChanged(object sender, EventArgs e)
        {

        }

        private void f6_TextChanged(object sender, EventArgs e)
        {

        }

        private void start2_Click(object sender, EventArgs e)
        {
            row = fpre.firtrow();
            fpre.data();
            fpre.details();
            start3.Enabled=true;
            start4.Enabled=true;
        }

        private void start3_Click(object sender, EventArgs e)
        {
            row++;
            while (fpre.fatorasize() == 0 && row <= fpre.lastrow())
            {
                row++;
            }
            if (row >= fpre.lastrow())
            {
                start3.Enabled = false;
            }
            if (row > fpre.lastrow())
            {
                row = fpre.firtrow();
                fpre.data();
                fpre.details();

            }
            else
            {
                fpre.data();
                fpre.details();

            }
        }

        private void start4_Click(object sender, EventArgs e)
        {
            row--;
            while (fpre.fatorasize() == 0 && row >= fpre.firtrow())
            {
                row--;
            }
            if (row <= fpre.firtrow())
            {
                start4.Enabled = false;
            }
            if (row < fpre.firtrow())
            {
                row = fpre.firtrow();
                fpre.data();
                fpre.details();

            }
            else
            {
                fpre.data();
                fpre.details();
            }
        }

        private void start5_Click(object sender, EventArgs e)
        {
            row = fpre.lastrow();
            fpre.data();
            fpre.details();
            start3.Enabled = true;
            start4.Enabled=true;
        }
    }
}