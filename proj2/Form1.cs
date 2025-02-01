using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Businessentity;

namespace proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                Application.Exit();
            }
            if (e.KeyCode == Keys.Enter && textBoxX1.Text.Trim().Length!=0)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            textBoxX2.Clear();
            checkBox2.Checked = false;
        }

        private void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            person p1 = new person();
            p1.name = textBoxX1.Text;
            p1.password = textBoxX2.Text;
            if (checkBox2.Checked == true)
            {
                if (textBoxX1.Text.Length==0&&textBoxX2.Text.Length==0)
                {
                    MessageBox.Show("اطلاعات به درستی وارد نشده است");
                    checkBox2.Checked=false;
                }
                else
                {
                    if (b1.register(textBoxX1.Text) == false)
                    {
                        if (b1.find_human(textBoxX1.Text).password == textBoxX2.Text)
                        {
                            if (MessageBox.Show("آیا میخواهید رمز عبورتان ذخیره شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                if (b1.register(textBoxX1.Text) == false)
                                {
                                    b1.save(p1);
                                    MessageBox.Show("ذخیره شد");
                                    textBoxX2.Focus();
                                }
                                else if (b1.register(textBoxX1.Text))
                                {
                                    button1.Focus();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("نمیتوان ذخیره کرد");
                            checkBox2.Checked = false;
                            textBoxX2.Focus();
                        }
                    }

                }
            }
            if (textBoxX2.Text.Trim().Length == 3 && checkBox2.Checked == false)
            {
                if (b1.find_human(textBoxX1.Text).password==textBoxX2.Text)
                {
                    if (MessageBox.Show("آیا میخواهید رمز عبورتان فراموش شود ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (b1.delete(p1))
                        {
                            MessageBox.Show("فراموش شد");
                            textBoxX2.Focus();
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("نمیتوان حذف کرد");
                    textBoxX2.Focus();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            human h1 = new human();
            h1.name_id = textBoxX1.Text;
            h1.password = textBoxX2.Text;
            if ((textBoxX1.Text.Trim().Length == 0) || (textBoxX2.Text.Trim().Length == 0))
            {
                MessageBox.Show("لطفا اطلاعات را کامل وارد کنید");

            }
            else
            {
            if (b1.check(h1) && b1.check2(textBoxX2.Text))
            {
                if (b1.find_human(textBoxX1.Text).password == textBoxX2.Text)
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری با رمز عبور هم خوانی ندارد");
                    textBoxX2.Focus();
                }

            }
            else
            {
                MessageBox.Show("قبلا ثبت نام نکرده اید");
            }
            }


        }
        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            BLl b1 = new BLl();
            var q = b1.find_human(textBoxX1.Text);
            if (e.KeyCode==Keys.CapsLock)
            {
                Form2 f2=new Form2();
                this.Hide();
                f2.ShowDialog();
            }
            if (e.KeyCode == Keys.Enter && textBoxX2.Text.Trim().Length!=0)
            {
                human h1 = new human();
                h1.name = textBoxX1.Text;
                h1.password = textBoxX2.Text;
                if (!b1.check(h1))
                {
                    button1.PerformClick();
                }
                else
                {
                    if (textBoxX2.Text.Trim().Length == 3)
                    {
                        if (q != null)
                        {
                            if (q.password == textBoxX2.Text)
                            {
                                button1.PerformClick();

                            }
                            else
                            {
                                MessageBox.Show("نام کاربری با رمز عبور هم خوانی ندارد");
                                textBoxX2.Focus();

                            }
                        }
                    }
                }
            }

        }

        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            BLl b1=new BLl();
            if (textBoxX1.Text.Trim().Length!=0)
            {
                if (b1.register(textBoxX1.Text))
                {
                    var q = b1.find(textBoxX1.Text);
                    textBoxX2.Text = q.password;
                    checkBox2.Checked = true;
                    textBoxX2.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            textBoxX2.PasswordChar = '*';
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            BLl b1 = new BLl();
            person p1 = new person();
            p1.name = textBoxX1.Text;
            p1.password = textBoxX2.Text;
            if (checkBox2.Checked == true)
            {
                if (textBoxX1.Text.Length == 0 && textBoxX2.Text.Length == 0)
                {
                    MessageBox.Show("اطلاعات به درستی وارد نشده است");
                    checkBox2.Checked = false;
                }
                else
                {
                    if (b1.register(textBoxX1.Text) == false)
                    {
                        if (b1.find_human(textBoxX1.Text).password == textBoxX2.Text)
                        {
                            if (MessageBox.Show("آیا میخواهید رمز عبورتان ذخیره شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                if (b1.register(textBoxX1.Text) == false)
                                {
                                    b1.save(p1);
                                    MessageBox.Show("ذخیره شد");
                                    textBoxX2.Focus();
                                }
                                else if (b1.register(textBoxX1.Text))
                                {
                                    button1.Focus();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("نمیتوان ذخیره کرد");
                            checkBox2.Checked = false;
                            textBoxX2.Focus();
                        }
                    }

                }
            }
            if (textBoxX2.Text.Trim().Length == 3 && checkBox2.Checked == false)
            {
                if (b1.find_human(textBoxX1.Text).password == textBoxX2.Text)
                {
                    if (MessageBox.Show("آیا میخواهید رمز عبورتان فراموش شود ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (b1.delete(p1))
                        {
                            MessageBox.Show("فراموش شد");
                            textBoxX2.Focus();
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("نمیتوان حذف کرد");
                    textBoxX2.Focus();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBoxX2.PasswordChar = '*';
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBoxX2.PasswordChar = '\0';
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }
    }
}
