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
    public partial class addmoney : DevExpress.XtraEditors.XtraForm, form.Interface.iaddmoney
    {
        logs.Presenter.massaddpresenter add;
        public string Name { get => textBox1.Text; set => textBox1.Text = value; }
        public int number { get => Convert.ToInt32(textBox2.Text); set => textBox2.Text = value.ToString(); }
        public DateTime date { get => Convert.ToDateTime(l1.Text); set => l1.Text = value.ToString(); }

        public addmoney()
        {
            InitializeComponent();
            add = new logs.Presenter.massaddpresenter(this);
         //   l2.Text = DateTime.Now.ToString("hh:mm");
            l1.Text = DateTime.Now.ToString("yyyy / MM / dd");
        }


        private void but8_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool check = add.addmoneyinset();
            if (check)
            {
                MessageBox.Show("تم الاضافة بنجاح");
                textBox1.Focus();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show( "هناك خطأ", MessageBoxIcon.Error.ToString());
            }

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void addmoney_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
         if(e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text != "")
                {
                    bool temp = false;
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if(textBox2.Text[i] != '1' && textBox2.Text[i] != '2' && textBox2.Text[i] != '3' && textBox2.Text[i] != '4' && textBox2.Text[i] != '5' && textBox2.Text[i] != '6' && textBox2.Text[i] != '7' && textBox2.Text[i] != '8' && textBox2.Text[i] != '9' && textBox2.Text[i] != '0')
                        {
                            temp = true;
                            break;
                        }
                        if (!temp)
                        {
                            simpleButton2.Focus();
                        e.Handled = e.SuppressKeyPress = true;
                        }
                        else
                        {
                            MessageBox.Show("لايمكن ترك هذا الحقل فارغا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("لايمكن ترك هذا الحقل فارغا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }

            }
        }

        private void simpleButton2_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}