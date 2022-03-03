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
    public partial class fatora3 : DevExpress.XtraEditors.XtraForm , form.Interface.fatora3interface
    {
        public DateTime fomedate { get => dateEdit1.DateTime; set => dateEdit1.DateTime = value; }
        public DateTime todate { get => date.DateTime; set => date.DateTime = value; }
        public decimal b1 { get =>Convert.ToDecimal( l1.Text); set => l1.Text = value.ToString(); }
        public decimal b2 { get => Convert.ToDecimal(l2.Text); set => l2.Text = value.ToString(); }
        logs.Presenter.fatora3presenter fpre;
        public fatora3()
        {
            InitializeComponent();
            fpre = new logs.Presenter.fatora3presenter(this);
        }

        private void fatora3_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            date.DateTime = DateTime.Now;
            
        //    l1.Text = fpre.sumsize().ToString();
                   }

        private void but3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void date_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(fpre.sumsize() != 0 )
            {
                fpre.sum();
                if (fpre.masrsize() != 0)
                {
                    fpre.masr();
                    l3.Text = (Convert.ToInt32(l1.Text) - Convert.ToInt32(l2.Text)).ToString();
                }
                else
                {
                    l2.Text = "0";
                    l3.Text = l1.Text;

                }
            }
            else { MessageBox.Show("لاتوجد فواتير في هذه الفنرة"); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}