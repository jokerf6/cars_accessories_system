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
    public partial class fatora2 : DevExpress.XtraEditors.XtraForm , form.Interface.fatora2interface
    {
        public decimal b1 { get => Convert.ToUInt32(lm1.Text); set => lm1.Text = value.ToString(); }
        public decimal b2 { get => Convert.ToInt32(lm2.Text); set => lm2.Text = value.ToString(); }
        logs.Presenter.fatora2presenter fpre;

        public fatora2()
        {
            InitializeComponent();
            fpre = new logs.Presenter.fatora2presenter(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but9_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void fatora2_Load(object sender, EventArgs e)
        {
            if (fpre.sumsize() != 0)
            {
                fpre.sum();
                if (fpre.masrsize() != 0)
                {
                    fpre.masr();
                    lm3.Text = (Convert.ToInt32(lm1.Text) - Convert.ToInt32(lm2.Text)).ToString();
                }
                else
                {
                    lm2.Text = "0";
                    lm3.Text = lm1.Text;

                }
            }
            else { MessageBox.Show("لاتوجد فواتير في هذه الفنرة"); }

        }
    }
    }
