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
    public partial class deletefatora : DevExpress.XtraEditors.XtraForm ,form.Interface.fawaterinterface
    {
        public int row { get =>Convert.ToInt32( fid.Value); set => fid.Value = value; }
        public DateTime date { get => datee.DateTime; set => datee.DateTime = value; }
        public object datagrid { get => dvg3.DataSource; set => dvg3.DataSource = value; }
        public int id { get =>Convert.ToInt32( fawater1.Text); set => fawater1.Text = value.ToString(); }
        public string name { get => fawater2.Text; set => fawater2.Text = value; }
        public decimal price { get => fawater5.Value; set => fawater5.Value = value; }
        public int number { get => Convert.ToInt32(fawater3.Value); set => fawater3.Value = value;}
        public decimal dis { get => fawater4.Value; set => fawater4.Value = value;}
        public decimal disfinal { get => dis1.Value;set => dis1.Value = value;}
        public decimal final { get => final1.Value; set => final1.Value = value; }

        logs.Presenter.fawaterpresenter fpre;
        public deletefatora()
        {
            InitializeComponent();
            fpre = new logs.Presenter.fawaterpresenter(this);
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

        private void deletefatora_Load(object sender, EventArgs e)
        {
            row = 0;
            fpre.fawaterdisplay();
            datee.DateTime = DateTime.Now;
            if(fpre.fawatersize() == 0)
            {
               start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                row = 0;
                fpre.fawaterdisplay();
                dis1.Value = 0;
                final1.Value = 0;

            }
            
            fawater1.Focus();

        }

        private void datee_EditValueChanged(object sender, EventArgs e)
        {
            if (fpre.fawatersize() == 0)
            {
                MessageBox.Show("لاتوجد فواتير" , " لا توجد فواتير" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                simpleButton3.Enabled = false;
                simpleButton5.Enabled = false;
                fawater1.Focus();
                row = 0;
                fpre.fawaterdisplay();
                dis1.Value = 0;
                final1.Value = 0;

            }
            else
            {
                start2.Enabled = true;
                start3.Enabled = true;
                start4.Enabled = true;
                start5.Enabled = true;
                simpleButton1.Enabled = true;
                simpleButton2.Enabled = true;
                simpleButton3.Enabled = true;
                simpleButton5.Enabled = true;
            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (fawater1.Text != "" && fawater2.Text != "")
            {
                fpre.decitems();
                bool check = fpre.deleteitemfawater();
                if (check)
                {
                    MessageBox.Show("تم الحذف ");
                    fpre.fawaterdisplay();
                    fpre.fawaterdisplayfinal();
                    fawater1.Text = "";
                    fawater2.Text = "";
                    fawater3.Value = 1;
                    fawater4.Value = 0;
                    fawater5.Value = 0;
                    fawater1.Focus();
                }
                else
                {
                    MessageBox.Show("هناك خطأ");
                }
            }
            else
            {
                fawater1.Focus();  
            }
        }

        private void dvg3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fabrica1DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fabrica1DataSetBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void start2_Click(object sender, EventArgs e)
        {
            row = fpre.firstid();
            fpre.fawaterdisplay();
            fpre.fawaterdisplayfinal();
            fpre.fawaterdisplaydis();
            
        }

        private void start3_Click(object sender, EventArgs e)
        {
            row++;
            while(fpre.fatorasize() == 0 && row <= fpre.lastrow())
            {
                row++;
            }
            if(row >= fpre.lastrow())
            {
                start3.Enabled = false;
            }
            if (row > fpre.lastrow() )
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

        private void start5_Click(object sender, EventArgs e)
        {
            row = fpre.lastrow();
            fpre.fawaterdisplay();
            fpre.fawaterdisplayfinal();
            fpre.fawaterdisplaydis();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(fawater1.Text != "" && fawater2.Text != "")
            {
                fpre.updatefawater();
                fpre.fawaterdisplay();
                fpre.fawaterdisplayfinal();
                fpre.fawaterdisplaydis();
                fawater1.Focus();
            }
            else
            {
                MessageBox.Show("ليس هناك منتجات لتعديلها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fawater1.Focus();
            }
        }

        private void fawater1_ValueChanged(object sender, EventArgs e)
        {
           bool check =  fpre.itemsdisplay();
            if (!check)
            {
                MessageBox.Show( "الصنف غير موجود في الفاتورة ", "خطأ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                fawater1.Focus();
            }
        }

        private void fawater3_ValueChanged(object sender, EventArgs e)
        {
            if (fawater1.Text != "" && fawater2.Text != "")
            {
                fpre.calculate2();
            }
            else
            {
                fawater1.Focus();
            }
        }

        private void fawater4_ValueChanged(object sender, EventArgs e)
        {
            if (fawater1.Text != "" && fawater2.Text != "")
            {
                fpre.calculate2();
            }
            else
            {
                fawater1.Focus();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (fawater1.Text != "" && fawater2.Text != "")
            {
                fpre.incitems();
                bool check = fpre.updateitemfawater();
                if (check)
                {
                    MessageBox.Show("تم لتعديل");
                    fpre.updatefawater();
                    fpre.fawaterdisplay();
                    fpre.fawaterdisplayfinal();
                    fpre.fawaterdisplaydis();
                    fawater3.Value = 1;
                    fawater4.Value = 0;
                    fawater5.Value = 0;
                    fawater2.Text = "";
                    fawater1.Focus();
                    fawater1.Select(0, fawater1.TextLength);
                }
                else
                {
                    MessageBox.Show("هناك خطأ");
                }
            }
            else
            {
                fawater1.Focus();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
  
                fpre.decallitems();
                fpre.deletefawater();
          
                if (fpre.fawatersize() == 0)
                {
                MessageBox.Show("لاتوجد فواتير ");
                start2.Enabled = false;
                start3.Enabled = false;
                start4.Enabled = false;
                start5.Enabled = false;
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                simpleButton3.Enabled = false;
                simpleButton5.Enabled = false;
                fawater1.Focus();
                row = 0;
                fpre.fawaterdisplay();
                dis1.Value = 0;
                final1.Value = 0;
                }
                else
                {
                        fpre.fawaterdisplay();
                        fpre.fawaterdisplayfinal();
                        fpre.fawaterdisplaydis();
                        fawater1.Focus();
                    
                }
                
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fawater1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (fawater1.Text != "")
                {
                    bool temp = false;
                    for (int i = 0; i < fawater1.Text.Length; i++)
                    {
                        if (fawater1.Text[i] != '1' && fawater1.Text[i] != '2' && fawater1.Text[i] != '3' && fawater1.Text[i] != '4' && fawater1.Text[i] != '5' && fawater1.Text[i] != '6' && fawater1.Text[i] != '7' && fawater1.Text[i] != '8' && fawater1.Text[i] != '9')
                        {
                            temp = true;
                            break;
                        }
                    }
                    if (!temp)
                    {
                        bool check = fpre.itemsdisplay();
                        if (!check)
                        {
                            MessageBox.Show("الصنف غير موجود في الفاتورة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            fawater1.Focus();
                            fawater1.Text = "";
                            e.Handled = e.SuppressKeyPress = true;

                        }
                        else
                        {
                            fawater3.Focus();
                            fawater3.Select(0 , fawater3.Value.ToString().Length);
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء ادخال بيانات صحيحة");
                        fawater1.Focus();
                        fawater1.Text = "";

                    }
                }
                e.Handled = e.SuppressKeyPress = true;

            }
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void fawater3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fawater4.Focus();
                fawater4.Select(0 , fawater4.Value.ToString().Length+3);
                e.Handled = e.SuppressKeyPress = true;

            }
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void fawater4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton3.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void simpleButton5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void simpleButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                simpleButton5.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
            if(e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void dvg3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}