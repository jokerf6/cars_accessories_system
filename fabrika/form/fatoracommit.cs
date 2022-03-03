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
    public partial class fatoracommit : DevExpress.XtraEditors.XtraForm, form.Interface.fatoracommitinerface
    {
        logs.Presenter.fatoracommitpresenter fpre;
        public object datagrid { get => dvg2.DataSource; set => dvg2.DataSource = value; }
        public int row { get => Convert.ToInt32(rows.Value); set => rows.Value = value; }
        public DateTime date { get => Convert.ToDateTime(datelabel.Text); set => datelabel.Text = value.ToString("yyyy / MM / dd"); }
        public decimal dis { get => dis1.Value; set => dis1.Value = value; }
        public decimal final { get => final1.Value; set => final1.Value = value; }
        public int itemid { get => Convert.ToInt32(fatoracommit1.Text); set => fatoracommit1.Text = value.ToString(); }
        public string itemname { get => fatoracommit2.Text; set => fatoracommit2.Text = value; }
        public decimal itemsell { get => fatoracommit5.Value; set => fatoracommit5.Value = value; }
        public int itemnumber { get => Convert.ToInt32(fatoracommit3.Value); set => fatoracommit3.Value = value; }
        public decimal itemdis { get => fatoracommit4.Value; set => fatoracommit4.Value = value; }
        public DateTime fatoradate { get => Convert.ToDateTime(l1.Text); set => l1.Text = value.ToString(); }
        public int fatoranumber2 { get => Convert.ToInt32(label4.Text); set => label4.Text = value.ToString(); }
        public decimal fatoradis { get => dis1.Value; set => dis1.Value = value; }
        public decimal fatorafinal { get => final1.Value; set => final1.Value = value; }

        public fatoracommit()
        {
            InitializeComponent();
            fpre = new logs.Presenter.fatoracommitpresenter(this);

        }

        private void but6_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.ExitThread();

        }

        private void but3_Click(object sender, EventArgs e)
        {

        }

        private void fatoracommit_Load(object sender, EventArgs e)
        {
            //
            label7.Text = fpre.getalldata2().ToString();

            l1.Text = DateTime.Now.ToString("yyyy / MM / dd");
            if(fpre.getalldata2() == 0)
            {
                fatoracommit1.Enabled = false;
                fatoracommit3.Enabled = false;
                fatoracommit4.Enabled = false;
                simpleButton3.Enabled = false;
                simpleButton4.Enabled = false;
                simpleButton7.Enabled = false;
                simpleButton2.Enabled = false;
                fcb1.Enabled = false;
                start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;

            }
            else
            {
                fatoracommit1.Enabled = true;
                fatoracommit3.Enabled = true;
                fatoracommit4.Enabled = true;
                simpleButton3.Enabled = true;
                simpleButton4.Enabled = true;
                simpleButton7.Enabled = true;
                simpleButton2.Enabled = true;
                fcb1.Enabled = true;
                start2.Enabled = true;
                start3.Enabled = true;
                start4.Enabled = true;
                start5.Enabled = true;
            }
            row = 0;
            fpre.getalldata();
            fatoracommit1.Focus();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            //          datelabel.Text = DateTime.Now.ToString("yyyy / MM / dd");


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            //            datelabel.Text = DateTime.Now.ToString("yyyy / MM / dd");

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            //datelabel.Text = DateTime.Now.ToString("yyyy / MM / dd");


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //  datelabel.Text = DateTime.Now.ToString("yyyy / MM / dd");

        }

        private void label7_Click(object sender, EventArgs e)
        {



        }

        private void dvg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fpre.fatora1sum();
        }

        private void start1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fatoracommit1_ValueChanged(object sender, EventArgs e)
        {
            fpre.autonumber();
        }

        private void fatoracommit3_ValueChanged(object sender, EventArgs e)
        {
            fpre.calculate1();
        }

        private void fatoracommit4_ValueChanged(object sender, EventArgs e)
        {
            fpre.calculate2();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (fatoracommit1.Text != "" && fatoracommit2.Text != "" && row != 0)
            {
                bool check = fpre.addnewitems();
                if (check)
                {
                    MessageBox.Show("تمت الاضاافة");
                    fpre.incitems();
                    fpre.updatefatora();
                    fpre.getalldata();
                    fpre.fatorasize();
                    fpre.fatora1sum();
                    fatoracommit1.Focus();
                    fatoracommit1.Select(0, fatoracommit1.Text.Length);
                    fatoracommit2.Text = "";
                    fatoracommit3.Value = 1;
                    fatoracommit4.Value = 0;
                    fatoracommit5.Value = 0;
                }
                else
                {
                    MessageBox.Show("هناك خطـأ");
                }
            }
            fatoracommit1.Focus();

        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            if (fatoracommit1.Text != "" && fatoracommit2.Text != "" && row !=0)
            {
                MessageBox.Show("تم الحذف");
                fpre.decitems();
                fpre.deletefromfatora();
                fpre.getalldata();
                fpre.fatorasize();

                fpre.fatora1sum();
                fatoracommit2.Text = "";
                fatoracommit3.Value = 1;
                fatoracommit4.Value = 0;
                fatoracommit5.Value = 0;

                fatoracommit1.Focus();
                fatoracommit1.Select(0, fatoracommit1.TextLength);
            }
            fatoracommit1.Focus();


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            bool check = fpre.fatorafinish();

            fpre.fh1totemp();
            fpre.temptofh1();
            if (check)
            {
                MessageBox.Show(" تمت الاضافة");
                label7.Text = fpre.getalldata2().ToString();

            }
            else
            {
                MessageBox.Show("هناك خطـأ");

            }
            int y = fpre.lastrow();
            row = fpre.firtrow();
            while (fpre.fatorasize() == 0 && row < y)
            {
                row++;
            }
            if (fpre.fatorasize() > 0)
            {
                fpre.getalldata();
                fpre.getadate();
                fpre.getdis();
                fpre.getfinal();
                fpre.fatorasize();
                fpre.fatora1sum();
            }
            else
            {
                row = 0;
                fpre.getalldata();
                fpre.getadate();
                fpre.getdis();
                fpre.getfinal();
                fpre.fatorasize();
                fpre.fatora1sum();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fpre.fatorasize();
        }

        private void start2_Click(object sender, EventArgs e)
        {

        }

        private void start2_Click_1(object sender, EventArgs e)
        {
            
                row = fpre.firtrow();
                fpre.getalldata();
                fpre.getadate();
                fpre.getdis();
                fpre.getfinal();
                fpre.fatorasize();
                fpre.fatora1sum();
           
        }

        private void start3_Click(object sender, EventArgs e)
        {
            if (row != 0)
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
                    row = fpre.lastrow();
                    fpre.getalldata();
                    fpre.getadate();
                    fpre.getdis();
                    fpre.getfinal();
                    fpre.fatorasize();
                    fpre.fatora1sum();
                }
                else
                {
                    row = fpre.firtrow();
                    fpre.getalldata();
                    fpre.getadate();
                    fpre.getdis();
                    fpre.getfinal();
                    fpre.fatorasize();
                    fpre.fatora1sum();
                }

            }
        }

        private void start4_Click(object sender, EventArgs e)
        {
            if (row != 0)
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
                    fpre.getalldata();
                    fpre.getadate();
                    fpre.getdis();
                    fpre.getfinal();
                    fpre.fatorasize();
                    fpre.fatora1sum();
                }
                else
                {
                    fpre.getalldata();
                    fpre.getadate();
                    fpre.getdis();
                    fpre.getfinal();
                    fpre.fatorasize();
                    fpre.fatora1sum();
                }

            }
        }
        private void start5_Click(object sender, EventArgs e)
        {
                row = fpre.lastrow();
                fpre.getalldata();
                fpre.getadate();
                fpre.getdis();
                fpre.getfinal();
                fpre.fatorasize();
                fpre.fatora1sum();
            
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        private void dis1_ValueChanged(object sender, EventArgs e)
        {
            fpre.fatora1sum();
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            if (row != 0)
            {
                bool check = fpre.fatorafinish();
                fpre.fh1totemp();
                fpre.temptofh1();
                if (check)
                {
                    MessageBox.Show(" تمت الاضافة");
                    label7.Text = fpre.getalldata2().ToString();
                    row = 0;
                    fpre.getalldata();
                    dis1.Value = 0;
                    final1.Value = 0;

                }
                else
                {
                    MessageBox.Show("هناك خطـأ");

                }
                if (fpre.getalldata2() == 0)
                {
                    fatoracommit1.Enabled = false;
                    fatoracommit3.Enabled = false;
                    fatoracommit4.Enabled = false;
                    simpleButton3.Enabled = false;
                    simpleButton4.Enabled = false;
                    simpleButton7.Enabled = false;
                    simpleButton2.Enabled = false;
                    fcb1.Enabled = false;
                    start2.Enabled = false;
                    start3.Enabled = false;
                    start4.Enabled = false;
                    start5.Enabled = false;
                }
            }
        }

        private void simpleButton2_Click_2(object sender, EventArgs e)
        {
            if (row != 0)
            {
                fpre.decallitems();
                fpre.fatorafinish1();
                MessageBox.Show("تم الحذف");
                row = 0;
                fpre.getalldata();
                dis1.Value = 0;
                final1.Value = 0;
                if (fpre.getalldata2() == 0)
                {
                    fatoracommit1.Enabled = false;
                    fatoracommit3.Enabled = false;
                    fatoracommit4.Enabled = false;
                    simpleButton3.Enabled = false;
                    simpleButton4.Enabled = false;
                    simpleButton7.Enabled = false;
                    simpleButton2.Enabled = false;
                    fcb1.Enabled = false;
                    start2.Enabled = false;
                    start3.Enabled = false;
                    start4.Enabled = false;
                    start5.Enabled = false;
                }
            }
        }
        private void simpleButton3_Click_2(object sender, EventArgs e)
        {
            if (fatoracommit1.Text != "" && fatoracommit2.Text != "" && row != 0)
            {
                fpre.incitems2();

                bool check = fpre.updatehelper1();
                if (check)
                {
                    MessageBox.Show("تم التعديل");
                    fpre.updatefatora();
                    fpre.getalldata();
                    fpre.fatorasize();
                    fpre.fatora1sum();
                    fatoracommit2.Text = "";
                    fatoracommit3.Value = 1;
                    fatoracommit4.Value = 0;
                   fatoracommit5.Value = 0;
                    fatoracommit1.Focus();
                    fatoracommit1.Select(0, fatoracommit1.TextLength);
                }
                else
                {
                    MessageBox.Show("هناك خطـأ");
                }
            }
            fatoracommit1.Focus();
        }

        private void fatoracommit1_TextChanged(object sender, EventArgs e)
        {


        }

        private void fatoracommit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (fatoracommit1.Text != "")
                {
                    bool temp = false;
                    for (int i = 0; i < fatoracommit1.Text.Length; i++)
                    {
                        if (fatoracommit1.Text[i] != '1' && fatoracommit1.Text[i] != '2' && fatoracommit1.Text[i] != '3' && fatoracommit1.Text[i] != '4' && fatoracommit1.Text[i] != '5' && fatoracommit1.Text[i] != '6' && fatoracommit1.Text[i] != '7' && fatoracommit1.Text[i] != '8' && fatoracommit1.Text[i] != '9')
                        {
                            MessageBox.Show("قم بادخال بيانات صحيحة" , "خطأ" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
                            fatoracommit1.Text = "";
                            fatoracommit1.Focus();
                            temp = true;
                            break;
                        }
                    }
                    if (!temp)
                    {
                        if(fpre.size() == 0)
                        {
                            MessageBox.Show("من فضلك ادخل الكود الصحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            fatoracommit1.Focus();
                        }
                        else
                        {
                            if(fpre.inorout() == 0)
                            {
                                fpre.autonumber();
                                simpleButton3.Enabled = false;
                                simpleButton4.Enabled = false;
                                simpleButton7.Enabled = true;
                            }
                            else
                            {
                                fpre.predisplay();
                                simpleButton3.Enabled = true;
                                simpleButton4.Enabled = true;
                                simpleButton7.Enabled = false;
                            }
                            fatoracommit3.Focus();
                            fatoracommit3.Select(0 , fatoracommit3.Value.ToString().Length);
                            e.Handled = e.SuppressKeyPress = true;
                        }
                    }
                }
            }
            if(e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled= e.SuppressKeyPress = true;
            }
        }

        private void fatoracommit3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fatoracommit4.Focus();
                fatoracommit4.Select(0, fatoracommit3.Value.ToString().Length+3);
                e.Handled = e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }
        private void fatoracommit4_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void simpleButton7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void simpleButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
            if (e.KeyCode == Keys.Left)
            {
                simpleButton4.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void simpleButton4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void dis1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void start2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void fatoracommit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void start4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void start5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void fatoracommit4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (fpre.inorout() == 0)
                {
                    simpleButton7.Focus();
                    e.Handled = e.SuppressKeyPress = true;
                }
                else
                {
                    simpleButton3.Focus();
                    e.Handled = e.SuppressKeyPress = true;

                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                fcb1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            
        }
    }
}