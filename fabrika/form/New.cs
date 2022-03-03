using DevExpress.XtraBars.Customization;
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
    public partial class New : DevExpress.XtraEditors.XtraForm, form.Interface.iaddnewitems
    {
        logs.Presenter.addnewitempresenter addni;
        public New()
        {
            InitializeComponent();
            addni = new logs.Presenter.addnewitempresenter(this);
        }

        public int id { get => Convert.ToInt32(newitems1.Text); set => newitems1.Text = value.ToString(); }
        public string name { get => newitems2.Text; set => newitems2.Text = value; }
        public int number { get => Convert.ToInt32(newitems3.Text); set => newitems3.Text = value.ToString(); }
        public double money1 { get => Convert.ToDouble(newitems4.Text); set => newitems4.Text = value.ToString(); }
        public double money2 { get => Convert.ToDouble(newitems5.Text); set => newitems5.Text = value.ToString(); }
        public double money3 { get => Convert.ToDouble(newitems6.Text); set => newitems6.Text = value.ToString(); }

        private void but6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void but8_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
                bool check = addni.addnewitems();
            if (check)
            {
                MessageBox.Show("تمت الاضافة بنجاح");
                addni.autonumber();
                newitems2.Text = "";
                newitems2.Focus();
                newitems3.Value = 1;
                newitems4.Value = 0;
                newitems5.Value = 0;
                newitems6.Value = 0;
                simpleButton2.Enabled = false;
            }
            else
            {
                MessageBox.Show("هنك خطـأ");
            }
        }

        private void New_Load(object sender, EventArgs e)
        {
            newitems2.Focus();
            simpleButton2.Enabled=false;

        }

        private void newitems1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newitems2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newitems2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (newitems2.Text != "")
                {
                    if (addni.search() != 0)
                    {
                        MessageBox.Show("هذا المنتج موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        newitems2.Focus();
                    }
                    else
                    {
                        newitems3.Focus();
                        e.Handled = e.SuppressKeyPress = true;
                        newitems3.Select(0, newitems3.Value.ToString().Length);

                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن ان يكون  هذا الحقل فارغا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newitems2.Focus();
                    e.Handled = e.SuppressKeyPress = true;

                }
            }
        }

        private void newitems3_KeyDown(object sender, KeyEventArgs e)
        {
   
        }

        private void newitems4_KeyDown(object sender, KeyEventArgs e)
        {

        }
        

        private void newitems5_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void newitems6_KeyDown(object sender, KeyEventArgs e)
        {

        }
        

        private void newitems4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void newitems6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newitems4_TextChanged(object sender, EventArgs e)
        {

        }

        private void newitems5_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                     newitems3.Focus();
                    newitems3.Select(0, 1);
                    e.Handled = e.SuppressKeyPress = true;
                        
           }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newitems3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newitems4.Focus();
                newitems4.Select(0, newitems4.Value.ToString().Length+3);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void newitems4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newitems5.Focus();
                newitems5.Select(0, newitems5.Value.ToString().Length+3);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void newitems5_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (newitems5.Value >= newitems4.Value)
                {
                    newitems6.Focus();
                    e.Handled = e.SuppressKeyPress = true;
                    newitems6.Value = newitems5.Value - newitems4.Value;
                    newitems6.Select(0, newitems6.Value.ToString().Length + 3);
                }
                else
                {
                    MessageBox.Show("سعر البيع اقل من سعر الشراء", "هل انت متأكد من الاستمرار", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
            }
        }

        private void newitems6_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2.Enabled = true;
                simpleButton2.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }


        //*****************************************************************
    }
        
 }
