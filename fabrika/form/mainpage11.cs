using DevExpress.XtraBars;
using fabrika.form;
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
    public partial class mainpage11 : DevExpress.XtraBars.Ribbon.RibbonForm, form.Interface.mainpage11interface
    {
        public decimal b1 { get =>Convert.ToUInt32(lm1.Text) ; set => lm1.Text = value.ToString(); }
        public decimal b2 { get => Convert.ToInt32(lm2.Text); set => lm2.Text = value.ToString(); }
        logs.Presenter.mainpage11presenter fpre;
        public mainpage11()
        {
            InitializeComponent();
            fpre = new logs.Presenter.mainpage11presenter(this);
        }

        private void but3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            fatora2 x = new fatora2();

            x.ShowDialog();

            this.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //this.Hide();
            fatora22 x = new fatora22();
            x.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            fatora1 x = new fatora1();
            x.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            fatora11 x = new fatora11();
            x.ShowDialog();
            
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            fatora3 x = new fatora3();
            x.ShowDialog();
           
        }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            masrr x = new masrr();
            x.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            fatora3 x = new fatora3();
            x.ShowDialog();
        }

        private void mainpage11_Load(object sender, EventArgs e)
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