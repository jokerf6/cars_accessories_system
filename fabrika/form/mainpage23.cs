using DevExpress.XtraBars;
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
    public partial class mainpage23 : DevExpress.XtraBars.Ribbon.RibbonForm, form.Interface.additeminfatorainterface
    {
        logs.Presenter.additeminfatorapresenter apresenter;
        public int id { get =>Convert.ToInt32(textBox1.Text); set => textBox1.Text = value.ToString(); }
        public string name { get => mainbaget2.Text; set => mainbaget2.Text = value; }
        public int number { get => Convert.ToInt32(maimpaget3.Value); set => maimpaget3.Value = value; }
        public decimal price { get =>Convert.ToInt32( mainpaget5.Text); set => mainpaget5.Text = value.ToString(); }
        public decimal dis { get => mainpaget4.Value; set => mainpaget4.Value = value; }
        public object datagrid { get => dvg2.DataSource; set => dvg2.DataSource = value; }
        public int fid { get => Convert.ToInt32(l3.Text) ; set => l3.Text = value.ToString(); }
        public DateTime date { get => Convert.ToDateTime(l1.Text); set => l1.Text = value.ToString(); }
        public int type { get => Convert.ToInt32(l9.Text); set => l9.Text = value.ToString();}
        public int number2 { get => Convert.ToInt32(t120.Text); set => t120.Text = value.ToString(); }
        public decimal diss { get => t9.Value; set => t9.Value = value; }
        public decimal final { get => l11.Value ; set => l11.Value = value; }
        public decimal backup { get => Convert.ToInt32(label10.Text); set => label10.Text = value.ToString(); }
        public int fid2 { get => Convert.ToInt32(n1.Text); set => n1.Text = value.ToString(); }
        int x;
        public mainpage23()
        {
            InitializeComponent();
            apresenter =new logs.Presenter.additeminfatorapresenter(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void mainpage23_Load(object sender, EventArgs e)
        {
            l1.Text = DateTime.Now.ToString("yyyy / MM / dd");
            textBox1.Focus();
            if (!apresenter.getalldata())
            {
                simpleButton1.Visible = false;
                simpleButton2.Visible = false;
                simpleButton3.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
            else
            {
                apresenter.getalldata();
                apresenter.count();
                simpleButton1.Visible = true;
                simpleButton2.Visible = true;
                simpleButton3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            deletefatora x = new deletefatora();
            x.ShowDialog();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            fatoracommit x = new fatoracommit();
            x.ShowDialog();
         //   this.Close();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            pre x = new pre();
            x.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            New x = new New();
            x.ShowDialog();
        }

        private void comb23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void but8_Click(object sender, EventArgs e)
        {
         //   System.Windows.Forms.Application.ExitThread();

        }

        private void but6_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.Application.ExitThread();

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            addmoney x = new addmoney();
            x.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            deletemoney x = new deletemoney();
            x.ShowDialog();
        }

        private void mainpaget3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainpaget4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            apresenter.fatorafinish();
            apresenter.addinfatora();
            apresenter.updatetemp();
            apresenter.deletetemp();
            apresenter.getalldata();
            MessageBox.Show("تمت الاضافة بنجاح");
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Focus();
          
            
        }


        private void mainpaget5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mainpaget5_ValueChanged(object sender, EventArgs e)
        {
        }

        private void maimpaget3_ValueChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                apresenter.calculate1();
            }
            else
            {
                //MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                maimpaget3.Value = 1;

            }

        }

        private void mainpaget1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mainpaget4_ValueChanged(object sender, EventArgs e)
        {


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

             apresenter.deletefromfatora();
                apresenter.getalldata();
                l11.Value -=Convert.ToDecimal( mainpaget5.Text); 
             
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            apresenter.fatorafinish1();
            apresenter.addinfatora1();
            apresenter.updatetemp2();
            apresenter.deletetemp();
            apresenter.getalldata();
            MessageBox.Show("تمت الاضافة بنجاح");
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            apresenter.decallitems();
            apresenter.deletetemp();
            apresenter.getalldata();
            MessageBox.Show("تم الحذف بنجاح");
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Focus();
        }

        private void mainpaget4_ValueChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                apresenter.calculate1();
            }
            else
            {
             //   MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                mainpaget4.Value = 0;
            }


        }

        private void t10_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void t9_ValueChanged(object sender, EventArgs e)
        {
             apresenter.calculate3() ;
        }

        private void t120_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainpaget1_ValueChanged_1(object sender, EventArgs e)
        {
           bool check = apresenter.autonumber();
            if (!check)
            {
                MessageBox.Show("من فضلك ادخل الكود الصحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void l3_TextChanged(object sender, EventArgs e)
        {

        }

        private void l11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                apresenter.compare();
                if (apresenter.itemssize() <= 1)
                {
                    MessageBox.Show("  عدد هذا المنتج هو" + apresenter.itemssize());
                }
                apresenter.tempupdate();
                apresenter.getalldata();
                apresenter.count();
                apresenter.calculate3();

                textBox1.Focus();
                textBox1.Select(0, textBox1.TextLength);
                mainbaget2.Text = "";
                maimpaget3.Value = 1;
                mainpaget4.Value = 0;
                mainpaget5.Text = "0";
            }
            else
            {
               // MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") { 
            bool check = apresenter.addnewitems();
            if (check)
            {
                apresenter.getalldata();
                if (!apresenter.getalldata())
                {
                    simpleButton1.Visible = false;
                    simpleButton2.Visible = false;
                    simpleButton3.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                }
                else
                {
                    apresenter.getalldata();
                    apresenter.count();
                       
                       apresenter.incitems();
                        if(apresenter.itemssize() <= 1)
                        {
                            MessageBox.Show("  عدد هذا المنتج هو" + apresenter.itemssize());
                        }
                    simpleButton1.Visible = true;
                    simpleButton2.Visible = true;
                    simpleButton3.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("هناك خطأ");
            }
            textBox1.Focus();
            textBox1.Text = "";
            mainbaget2.Text = "";
            maimpaget3.Value = 1;
            mainpaget4.Value = 0;
            mainpaget5.Text = "0";
        }
            else
            {
                //MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                apresenter.decitems();
                apresenter.deletefromfatora();
                apresenter.getalldata();
                l11.Value -= Convert.ToInt16(mainpaget5.Text);
                textBox1.Focus();
                textBox1.Text = "";
                mainbaget2.Text = "";
                maimpaget3.Value = 1;
                mainpaget4.Value = 0;
                mainpaget5.Text = "0";
            }
            else
            {
               // MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    bool temp = false;
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (textBox1.Text[i] != '1' && textBox1.Text[i] != '2' && textBox1.Text[i] != '3' && textBox1.Text[i] != '4' && textBox1.Text[i] != '5' && textBox1.Text[i] != '6' && textBox1.Text[i] != '7' && textBox1.Text[i] != '8' && textBox1.Text[i] != '9')
                        {
                            MessageBox.Show("قم بادخال بيانات صحيحة");
                            textBox1.Text = "";
                            textBox1.Focus();
                            temp = true;
                            break;
                        }
                    }

                    if (!temp)
                    {
                        bool check = apresenter.autonumber();
                        if (!check)
                        {
                 //           MessageBox.Show("من فضلك ادخل الكود الصحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Focus();
                        }
                        else
                        {
                            if (!apresenter.searchintemp())
                            {
                                button2.Visible = false;
                                button3.Visible = false;
                                button1.Visible = true;
                            }
                            else
                            {
                                button1.Visible = false;
                                button2.Visible = true;
                                button3.Visible = true;
                                apresenter.show();
                            }

                            maimpaget3.Focus();
                            maimpaget3.Select(0, maimpaget3.Value.ToString().Length);
                            e.Handled = e.SuppressKeyPress = true;
                        }

                    }


                }
                else
                {
                   // MessageBox.Show("برجاء ملئ حقل الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                e.Handled = e.SuppressKeyPress = true;
            }
                if (e.KeyCode == Keys.Escape)
                {
                    simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }

        }

        private void maimpaget3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mainpaget4.Focus();
                mainpaget4.Select(0, mainpaget4.Value.ToString().Length + 3);
                e.Handled = e.SuppressKeyPress = true;
                apresenter.calculate1();
            }
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }

        }

        private void mainpaget4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!apresenter.searchintemp())
                {
                   
                    button1.Focus();
                    e.Handled = e.SuppressKeyPress=true;

                }
                else
                {
             
                    button2.Focus();
                    e.Handled = e.SuppressKeyPress = true;

                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (textBox1.Text != "")
                {
                    button3.Focus();
                    e.Handled = e.SuppressKeyPress = true;

                }
                else
                {
                    //MessageBox.Show("برجاء ملئ حقل الكود" , "خطأ" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    textBox1.Focus();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }

        }

        private void simpleButton1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void mainpage23_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                simpleButton1.Focus();
            }
        }

        private void جرد_ItemClick(object sender, ItemClickEventArgs e)
        {
            deletemoney x = new deletemoney();
            x.ShowDialog();
        }

        private void dvg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
           fatora2 x = new fatora2();
            x.ShowDialog();
        }
    }
}