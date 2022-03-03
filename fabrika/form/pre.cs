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

    public partial class pre : DevExpress.XtraEditors.XtraForm,form.Interface.preitemnumberinterface
    {
        logs.Presenter.preitemnumberpresenter adpreitem;

        public int id { get =>Convert.ToInt32(preitem1.Text); set => preitem1.Text = value.ToString(); }
        public string name { get => preitem2.Text; set => preitem2.Text = value; }
        public int number { get => Convert.ToInt32(p3.Text); set => p3.Text = value.ToString(); }
        public decimal money1 { get => Convert.ToDecimal(preitem4.Text); set => preitem4.Text = value.ToString(); }
        public decimal money2 { get => Convert.ToDecimal(preitem5.Text); set => preitem5.Text = value.ToString(); }
        public decimal money3 { get => Convert.ToDecimal(preitem6.Text); set => preitem6.Text = value.ToString(); }


        public pre()
        {
            InitializeComponent();
            adpreitem = new logs.Presenter.preitemnumberpresenter(this);
        }
   

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void but8_Click(object sender, EventArgs e)
        {
           this.Hide();
            this.Close();
        }

        private void pre_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }

        private void preitem2_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void preitem1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (preitem1.Text != "")
                {
                    bool temp = false;
                    for (int i = 0; i < preitem1.Text.Length; i++)
                    {
                        if (preitem1.Text[i] != '1' && preitem1.Text[i] != '2' && preitem1.Text[i] != '3' && preitem1.Text[i] != '4' && preitem1.Text[i] != '5' && preitem1.Text[i] != '6' && preitem1.Text[i] != '7' && preitem1.Text[i] != '8' && preitem1.Text[i] != '9')
                        {
                            MessageBox.Show("قم بادخال بيانات صحيحة");
                            preitem1.Text = "";
                            preitem1.Focus();
                            temp = true;
                            break;
                        }
                    }

                    if (!temp)
                    {
                       // bool check = apresenter.autonumber();
                        if (adpreitem.check1() == 0)
                        {
                            MessageBox.Show("من فضلك ادخل الكود الصحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            preitem1.Focus();
                        }
                        else
                        {
                            adpreitem.autonumber();
                            p3.Focus();
                            p3.Select(0, p3.Value.ToString().Length);
                            e.Handled = e.SuppressKeyPress = true;
                        }

                    }


                }
                else
                {
                    MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    preitem1.Focus();
                }
            }
        }

        private void p3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                preitem4.Focus();
                preitem4.Select(0 , preitem4.Value.ToString().Length);
                e.Handled=e.SuppressKeyPress = true;
            }
        }

        private void preitem4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                preitem5.Focus();
                preitem5.Select(0, preitem4.Value.ToString().Length);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void preitem5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                preitem6.Value = preitem5.Value - preitem4.Value;
                preitem6.Focus();
                preitem6.Select(0, preitem4.Value.ToString().Length);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void preitem6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1.Enabled=true;
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            adpreitem.addpreitems();
            preitem1.Text = "";
            preitem2.Text = ""; 
            p3.Value = 1;
            preitem4.Value = 0;
            preitem5.Value = 0;
            preitem6.Value = 0;
            preitem1.Focus();
            preitem1.Select(0, preitem1.TextLength);
        }
    }
}