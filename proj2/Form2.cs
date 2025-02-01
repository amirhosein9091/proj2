using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Businessentity;
using DevComponents.DotNetBar;

namespace proj2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public bool b;
        public int idi;
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            
            //button1.Visible = true;
            //button2.Visible = false;
            human h1 = new human();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = b1.read_human();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = b1.read_human();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = b1.read_human();
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = b1.read_kala();
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = b1.read_kala();
            if (comboBox5.SelectedItem == null)
            {
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = b1.read_kala();
            }
            else if (comboBox5.SelectedItem == "لوازم ورزشی")
            {
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = b1.read_sport();
            }
            else if (comboBox5.SelectedItem == "پوشاک")
            {
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = b1.read_poshak();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            ////if (textBoxX3.Text.Trim().Length == 3)
            ////{

            //    if (textBoxX3.Text != textBoxX2.Text)
            //    {
            //        a = false;
            //        errorProvider1.SetError(textBoxX3, "رمز عبور هم خوانی ندارد");
            //    }
            ////}
            //else
            //{
            //    a = true;
            //    errorProvider1.Clear();
            //}
        }

       

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    e.SuppressKeyPress = true;
            //    this.Close();
            //}
            //if (e.KeyCode == Keys.Enter && textBoxX1.Text.Trim().Length != 0)
            //{
            //    SelectNextControl(ActiveControl, true, true, true, true);
            //}
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && textBoxX1.Text.Trim().Length != 0)
            //{
            //    SelectNextControl(ActiveControl, true, true, true, true);
            //}
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //dataGridView1.Columns["name"].HeaderText = "نام کاربری";
            //dataGridView1.Columns["password"].HeaderText = "رمز عبور";
            //dataGridView1.Columns["id"].Visible = false;           
            //dataGridView1.Columns["name"].Width = 253;
            //dataGridView1.Columns["password"].Width = 254;
            
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //idi = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //human h1 = new human();
            //BLl b1 = new BLl();
            //if (MessageBox.Show("اطمینان دارید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    if(b1.deleteh(idi))
            //    {
                    
            //        MessageBox.Show("با موفقیت حذف شد");
            //        dataGridView1.DataSource = null;
            //        dataGridView1.DataSource = b1.read();
            //    }

            //}
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void textBoxX3_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter /*&& textBoxX.Text.Trim().Length != 0*/)
            //{
            //    SelectNextControl(ActiveControl, true, true, true, true);
            //}
        }
        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
			//if (textBoxX3.Text != textBoxX2.Text)
			//{
			//	errorProvider1.SetError(textBoxX3, "رمز عبور هم خوانی ندارد");
			//}
			//else
   //         {
			//	errorProvider1.Clear();
			//}
		}
        private void button8_Click_1(object sender, EventArgs e)
        {
            //textBoxX1.Clear();
            //textBoxX2.Clear();
            //textBoxX3.Clear();
            //textBoxX1.Focus();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //BLl b1 = new BLl();
            //dataGridView2.DataSource = "null";
            //dataGridView2.DataSource = b1.read_kala();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            human h1 = new human();
            BLl b1 = new BLl();
            h1.name = textBox1.Text;
            h1.family = textBox2.Text;
            h1.code = textBox3.Text;
            h1.phone = textBox4.Text;
            h1.gender = comboBox1.SelectedItem.ToString();
            h1.birthd=maskedTextBox1.Text;
            h1.registerd=maskedTextBox2.Text;
            h1.address = textBox5.Text;
            h1.photo = "123";
            h1.name_id= textBox6.Text;
            h1.password = textBox7.Text;
            if (b1.check(h1)==false)
            {
                if (b == true)
                {
                    if (b1.saveh(h1))
                    {
                        MessageBox.Show("ثبت شد");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        maskedTextBox1.Clear();
                        maskedTextBox2.Clear();
                        comboBox1.SelectedItem = null;
                        textBox1.Focus();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = b1.read_human();
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = b1.read_human();
                    }
                }
                else
                {
                    MessageBox.Show("رمز عبور با تکرار آن هم خوانی ندارد");
                }
            }
            else
            {
                MessageBox.Show("این کاربر وجود دارد");
                textBox6.Focus();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != textBox8.Text)
            {
                errorProvider1.SetError(textBox8, "رمز عبور همخوانی ندارد");
                b = false;
            }
            else
            {
                errorProvider1.Clear();
                b = true;
            }
            
        }
        string loc;
        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            loc = openFileDialog1.FileName;
            pictureBox1.ImageLocation = loc;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            human h1=new    human();
            BLl b1=new BLl();
            h1.name_id=textBox6.Text;
            if (textBox6.Text.Length==3)
            {
                if (b1.check(h1))
                {
                    errorProvider1.SetError(textBox6, "این نام کاربری وجود دارد");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["name"].HeaderText = "نام";
            dataGridView1.Columns["family"].HeaderText = "نام خانوادگی";
            dataGridView1.Columns["code"].HeaderText = "کدملی";
            dataGridView1.Columns["phone"].HeaderText = "شماره تماس";
            dataGridView1.Columns["gender"].HeaderText = "جنسیت";
            dataGridView1.Columns["birthd"].HeaderText = "تاریخ تولد";
            dataGridView1.Columns["registerd"].HeaderText = "تاریخ ثبت";
            dataGridView1.Columns["address"].HeaderText = "آدرس";
            dataGridView1.Columns["name_id"].HeaderText = "نام کاربری";
            dataGridView1.Columns["password"].HeaderText = "رمز عبور";
            dataGridView1.Columns["id"].Visible = false;
            //dataGridView1.Columns["name"].Width = 253;
            //dataGridView1.Columns["password"].Width = 254;
        }

        private void ویرایشToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            human h1 = new human();
            var q = b1.updateh(idi2);
            textBox9.Text = q.name;
            textBox13.Text = q.family;
            textBox12.Text = q.code;
            textBox10.Text = q.address;
            textBox11.Text = q.phone;
            comboBox2.Text = q.gender;
            maskedTextBox3.Text = q.birthd;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            human h1 = new human();
            BLl b1 = new BLl();
            h1.name = textBox9.Text;
            h1.family=textBox13.Text;
            h1.code=textBox12.Text;
            h1.address=textBox10.Text;
            h1.phone=textBox11.Text;
            h1.gender=comboBox2.SelectedItem.ToString();
            h1.birthd=maskedTextBox3.Text;
            var q = b1.find_human2(textBox9.Text);
            h1.name_id = q.name_id;
            h1.password = q.password;
            h1.photo = q.photo;
            h1.registerd = q.registerd;
            if (b1.edith(h1, idi2)||b1.edith2(h1,textBox9.Text))
            {
                MessageBox.Show("ویرایش شد");
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox9.Clear();
                comboBox2.Text = null;
                maskedTextBox3.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = b1.read_human();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = b1.read_human();

            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            if (textBox16.Text.Length==0)
            {
                dataGridView3.DataSource = null;
            }
            else
            {
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = b1.search_name(textBox16.Text);
            }
        }
        int idi2;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idi2 = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            human h1=new human();
            BLl b1 = new BLl();
            var q = b1.selecth(textBox14.Text);
            textBox9.Text = q.name;
            textBox13.Text = q.family;
            textBox12.Text = q.code;
            textBox10.Text = q.address;
            textBox11.Text = q.phone;
            comboBox2.Text = q.gender;
            maskedTextBox3.Text = q.birthd;

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox9.Clear();
            comboBox2.Text = null;
            maskedTextBox3.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            human h1 = new human();
            BLl b1 = new BLl();
            var q = b1.selecth(textBox15.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            if (textBox15.Text.Length==0)
            {
                dataGridView3.DataSource = null;
            }
            else
            {
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = b1.search_name_id(textBox15.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BLl b1=new BLl();
            if (textBox15.Text.Length==3)
            {
                if (MessageBox.Show("مطمعنید؟", "delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    if (b1.deleteh2(textBox15.Text)||b1.deleteh(idi))
                    {
                        MessageBox.Show("حذف شد");
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = b1.read_human();
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = b1.read_human();
                    }
                }
            }
        }

        private void حذفToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            human h1 = new human();
            BLl b1 = new BLl();
            if (MessageBox.Show("اطمینان دارید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (b1.deleteh(idi4))
                {

                    MessageBox.Show("با موفقیت حذف شد");
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = b1.read_human();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = b1.read_human();
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            kala k1 = new kala();
            if (comboBox5.SelectedItem == "لوازم ورزشی")
            {
                sport s1 = new sport();              
                k1.name=s1.name = textBox17.Text;
                k1.size=s1.size = comboBox3.SelectedItem.ToString();
                k1.color=s1.color = textBox18.Text;
                k1.number=s1.number = Convert.ToInt32(textBox19.Text);
                k1.bprice=s1.bprice = Convert.ToInt32(textBox20.Text);
                k1.sprice=s1.sprice = Convert.ToInt32(textBox21.Text);
                k1.type=s1.type = comboBox5.SelectedItem.ToString();
                k1.goal=s1.goal = comboBox4.SelectedItem.ToString();
                if (b1.saveS(s1))
                {
                    b1.savek(k1);
                    MessageBox.Show("ثبت شد");
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = b1.read_kala();
                    dataGridView5.DataSource = null;
                    comboBox5.SelectedItem = null;
                    textBox17.Clear();
                    comboBox3.SelectedItem = null;
                    textBox18.Clear();
                    comboBox4.SelectedItem = null;
                    textBox19.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox17.Focus();

                }
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = b1.read_sport();
            }
            else if (comboBox5.SelectedItem == "پوشاک")
            {
                poshak p1 = new poshak();
                k1.name=p1.name = textBox17.Text;
                k1.size=p1.size = comboBox3.SelectedItem.ToString();
                k1.color=p1.color = textBox18.Text;
                k1.number=p1.number = Convert.ToInt32(textBox19.Text);
                k1.bprice=p1.bprice = Convert.ToInt32(textBox20.Text);
                k1.sprice=p1.sprice = Convert.ToInt32(textBox21.Text);
                k1.type=p1.type = comboBox5.SelectedItem.ToString();
                k1.goal=p1.goal = comboBox4.SelectedItem.ToString();
                if (b1.savep(p1))
                {
                    MessageBox.Show("ثبت شد");
                    b1.savek(k1);
                    textBox17.Clear();
                    comboBox3.SelectedItem = null;
                    textBox18.Clear();
                    comboBox4.SelectedItem = null;
                    comboBox5.SelectedItem = null;
                    textBox19.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox17.Focus();

                }
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = b1.read_poshak();
            }
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
            comboBox3.SelectedItem = null;
            comboBox5.SelectedItem = null;
            textBox18.Clear();
            comboBox4.SelectedItem = null;
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox17.Focus();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }
        int idi4;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idi4= (int)dataGridView3.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBox6.SelectedItem = null;
            textBox7.Clear();
            comboBox8.SelectedItem = null;
            comboBox10.SelectedItem = null;
            textBox27.Clear();
            textBox26.Clear();
            textBox25.Clear();
            textBox24.Clear();
            textBox23.Clear();
        }
        int idi3;
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idi3 = (int)dataGridView5.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BLl b1=new BLl();
            
            if (comboBox6.SelectedItem=="لوازم ورزشی")
            {
                sport s1=new sport();
                kala k1 = new kala();
                k1.name=s1.name=textBox27.Text;
                k1.size = s1.size=textBox8.Text;
                k1.color = s1.color=textBox26.Text;
                k1.number = s1.number=Convert.ToInt32(textBox25.Text);
                k1.bprice = s1.bprice = Convert.ToInt32(textBox24.Text);
                k1.sprice = s1.sprice = Convert.ToInt32(textBox23.Text);
                k1.type = s1.type = comboBox6.SelectedItem.ToString();
                k1.goal = s1.goal = comboBox7.SelectedItem.ToString();
                if (b1.edits(s1))
                {
                    b1.editk(k1);
                    MessageBox.Show("ویرایش شد");
                    comboBox6.SelectedItem = null;
                    textBox7.Clear();
                    comboBox8.SelectedItem = null;
                    textBox27.Clear();
                    textBox26.Clear();
                    textBox25.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    comboBox10.SelectedItem = null;
                    dataGridView5.DataSource = null;
                    dataGridView5.DataSource = b1.read_kala();
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = b1.read_kala();

                }
            }
            else if (comboBox6.SelectedItem=="پوشاک")
            {
                poshak p1=new   poshak();
                kala k1 = new kala();
                k1.name = p1.name = textBox27.Text;
                k1.size = p1.size = textBox8.Text;
                k1.color = p1.color = textBox26.Text;
                k1.number = p1.number = Convert.ToInt32(textBox25.Text);
                k1.bprice = p1.bprice = Convert.ToInt32(textBox24.Text);
                k1.sprice = p1.sprice = Convert.ToInt32(textBox23.Text);
                k1.type = p1.type = comboBox6.SelectedItem.ToString();
                k1.goal=p1.goal= comboBox7.SelectedItem.ToString();
                if (b1.editp(p1))
                {
                    MessageBox.Show("ویرایش شد");
                    b1.editk(k1);
                    comboBox6.SelectedItem = null;
                    textBox7.Clear();
                    comboBox8.SelectedItem = null;
                    textBox27.Clear();
                    textBox26.Clear();
                    textBox25.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    comboBox10.SelectedItem = null;
                    dataGridView5.DataSource = null;
                    dataGridView5.DataSource = b1.read_kala();
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = b1.read_kala();

                }

            }
            else
            {
                MessageBox.Show("گروه کالا را وارد کنید");
                comboBox6.Focus();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            kala k1 = new kala();
            var q = b1.selectk(idi3);
            textBox27.Text = q.name;
            comboBox8.SelectedItem = q.size;
            textBox26.Text = q.color;
            textBox25.Text = q.number.ToString();
            textBox24.Text = q.bprice.ToString();
            textBox23.Text = q.sprice.ToString();
            comboBox6.SelectedItem = q.type;
            comboBox7.SelectedItem = q.goal;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLl b1=new BLl();
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = b1.read_kala();
            if (comboBox10.SelectedItem==null)
            {
                dataGridView5.DataSource = null;
                dataGridView5.DataSource = b1.read_kala();
            }
            else if (comboBox10.SelectedItem=="لوازم ورزشی")
            {
                dataGridView5.DataSource = null;
                dataGridView5.DataSource = b1.read_sport();
            }
            else if (comboBox10.SelectedItem=="پوشاک")
            {
                dataGridView5.DataSource = null;
                dataGridView5.DataSource = b1.read_poshak();
            }
        }

        private void comboBox10_Leave(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            if (comboBox10.SelectedItem==null)
            {
                dataGridView5.DataSource=null;
                dataGridView5.DataSource = b1.read_kala();
            }
        }

        private void dataGridView5_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView5.Columns["name"].HeaderText = "نام کالا";
            dataGridView5.Columns["size"].HeaderText = "سایز کالا";
            dataGridView5.Columns["color"].HeaderText = "رنگ بندی";
            dataGridView5.Columns["number"].HeaderText = "شماره تماس";
            dataGridView5.Columns["bprice"].HeaderText = "قیمت خرید";
            dataGridView5.Columns["sprice"].HeaderText = "قیمت فروش";
            dataGridView5.Columns["type"].HeaderText = "گروه کالا";
            dataGridView5.Columns["goal"].HeaderText = "خریدار هدف";
            dataGridView5.Columns["id"].Visible = false;

        }

        private void dataGridView4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView4.Columns["name"].HeaderText = "نام کالا";
            dataGridView4.Columns["size"].HeaderText = "سایز کالا";
            dataGridView4.Columns["color"].HeaderText = "رنگ بندی";
            dataGridView4.Columns["number"].HeaderText = "شماره تماس";
            dataGridView4.Columns["bprice"].HeaderText = "قیمت خرید";
            dataGridView4.Columns["sprice"].HeaderText = "قیمت فروش";
            dataGridView4.Columns["type"].HeaderText = "گروه کالا";
            dataGridView4.Columns["goal"].HeaderText = "خریدار هدف";
            dataGridView4.Columns["id"].Visible = false;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    

}
