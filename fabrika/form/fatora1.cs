using DevExpress.XtraEditors;
using fabrika.form.Interface;
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
    public partial class fatora1 : DevExpress.XtraEditors.XtraForm , form.Interface.fatora1interface
    {
        DateTime fatora1interface.date { get => date.DateTime; set => date.DateTime = value; }
        public int row { get => Convert.ToInt32(fk.Text); set => fk.Text = value.ToString(); }
        public object datagrid { get => dvg4.DataSource; set => dvg4.DataSource = value; }
        public decimal final { get => Convert.ToInt32(f6.Text); set => f6.Text = value.ToString(); }
        public decimal disfinal { get => Convert.ToInt32(f5.Text); set => f5.Text = value.ToString(); }
        public int number { get => Convert.ToInt32(f1.Text); set => f1.Text = value.ToString(); }
        public decimal masr { get => Convert.ToDecimal(f3.Text); set => f3.Text = value.ToString(); }
        public decimal dis { get => Convert.ToDecimal(f2.Text); set => f2.Text = value.ToString(); }
        public decimal final2 { get => Convert.ToDecimal(f4.Text); set => f4.Text = value.ToString(); }
        logs.Presenter.fatora1presenter fpre;
        public fatora1()
        {
            InitializeComponent();
            fpre = new logs.Presenter.fatora1presenter(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fatora1_Load(object sender, EventArgs e)
        {
            date.DateTime = DateTime.Now;
            row = 0;
            fpre.fawaterdisplay();
            if (fpre.fawatersize() != 0)
            {
                fpre.sumfinal();
                fpre.fawatersize();
                fpre.sumdis();
                if (fpre.masrsize() != 0)
                {
                    fpre.summasr();
                }
                else
                {
                    f3.Text = "0";
                }
                start2.Enabled = true;
                start3.Enabled = true;
                start4.Enabled = true;
                start5.Enabled = true;
            }
            else
            {
                start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;
                f1.Text = "0";
                f2.Text = "0";
                f3.Text = "0";
                f4.Text = "0";
                f5.Text = "0";
                f6.Text = "0";
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            row = fpre.firstid();
            fpre.fawaterdisplay();
            fpre.fawaterdisplayfinal();
            fpre.fawaterdisplaydis();
        }

        private void date_EditValueChanged(object sender, EventArgs e)
        {
            if (fpre.fawatersize() != 0)
            {
                fpre.fawatersize();
                fpre.sumdis();
                fpre.sumfinal();
                if (fpre.masrsize() != 0)
                {
                    fpre.summasr();
                }
                else
                {
                    f3.Text = "0";
                }

                start2.Enabled = true;
                start3.Enabled = true;
                start4.Enabled = true;
                start5.Enabled = true;
            }
            else
            {
                start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;
                f1.Text = "0";
                f2.Text = "0";
                f3.Text = "0";
                f4.Text = "0";
                f5.Text = "0";
                f6.Text = "0";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            row = fpre.firstid();
            fpre.fawaterdisplay();
            fpre.fawaterdisplayfinal();
            fpre.fawaterdisplaydis();
        }

        private void start2_Click(object sender, EventArgs e)
        {
            row = fpre.firstid();
            fpre.fawaterdisplay();
            fpre.fawaterdisplaydis();
            fpre.fawaterdisplayfinal();
            start3.Enabled =true;
            start4.Enabled = true;
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
                row = fpre.firstid();
                fpre.fawaterdisplay();
                fpre.fawaterdisplayfinal();
                fpre.fawaterdisplaydis();

            }
            else
            {
                fpre.fawaterdisplay();
                fpre.fawaterdisplayfinal();
                fpre.fawaterdisplaydis();

            }
        }

        private void start5_Click(object sender, EventArgs e)
        {
            row = fpre.lastrow();
            fpre.fawaterdisplay();
            fpre.fawaterdisplayfinal();
            fpre.fawaterdisplaydis();
            start3.Enabled = true;
            start4.Enabled = true;
        }

        private void start4_Click(object sender, EventArgs e)
        {
            row--;
            while (fpre.fatorasize() == 0 && row >= fpre.firstid())
            {
                row--;
            }
            if (row <= fpre.firstid())
            {
                start4.Enabled = false;
            }
            if (row < fpre.firstid())
            {
                row = fpre.firstid();
                fpre.fawaterdisplay();
                fpre.fawaterdisplayfinal();
                fpre.fawaterdisplaydis();

            }
            else
            {
                fpre.fawaterdisplay();
                fpre.fawaterdisplayfinal();
                fpre.fawaterdisplaydis();

            }
        }
    }
}