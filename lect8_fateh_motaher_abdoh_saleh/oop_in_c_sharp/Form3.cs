using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_in_c_sharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            { textBox1.SelectedText = null; }
            else
                MessageBox.Show("لا يوجد نص محدد ");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text= textBox1.Text.Trim().Length.ToString() ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {if (textBox1.SelectedText.Length > 0)
                textBox3.Text = textBox1.SelectedText.Length.ToString();
            else
                MessageBox.Show("لا يوجد نص محدد");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            string[] str = textBox1.Text.Trim().Split(' ');
            textBox4.Text =(str.Length-1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            { textBox1.SelectionLength = 0; }
            else
                MessageBox.Show("لا يوجد نص محدد");

        }
        string copytext;
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != null)
            {
                copytext = textBox1.SelectedText;
            }
            else
                MessageBox.Show("لايوجد نص محدد للنسخ");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectedText!=null)
            { copytext = textBox1.SelectedText;
                textBox1.SelectedText = null;
            }
            else
                MessageBox.Show("لايوجد نص محدد للنسخ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (copytext != null)
            {
                textBox5.Text += "\r\n"+copytext;
            }
            else
                MessageBox.Show("لايوجد نص منسوخ مسبقا ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox5.Undo();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != null)
            {
                char[] temp = textBox1.SelectedText.ToArray();
                for (int i = 0; i < temp.Length; i++)
                    textBox6.Text += "\r\n"+temp[i].ToString();
            }
            else
                MessageBox.Show("النص غير محدد");
        }

        private void button12_Click(object sender, EventArgs e)
        {if (textBox1.SelectedText != null)
            { string[] word = textBox1.SelectedText.Split(' ');
                for (int i = 0; i < word.Length; i++)
                    if (word[i] != " ")
                        textBox7.Text += "\r\n"+word[i];
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != null)
            {
                int index = textBox1.Text.IndexOf(textBox10.Text.Trim(), 0);
                if (index > -1)
                {
                    textBox1.SelectionStart = index;
                    textBox1.SelectionLength = textBox10.Text.Length;
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("ليس موجود");
            }
            else
                MessageBox.Show("ادخل النص المراد البحث عنه");
        }

        private void button14_Click(object sender, EventArgs e)
        {if (textBox10.Text.Trim() != "")
            {
                int index = textBox1.Text.IndexOf(textBox10.Text, textBox1.SelectionStart + textBox1.SelectionLength);

                if (index > -1)
                {
                    textBox1.Focus();
                    textBox1.Select(index, textBox10.Text.Length);
                }
                else
                    MessageBox.Show("not found");
            }
            else
                MessageBox.Show("ادخل النص المراد البحث عنه");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Trim() != "")
            {
                int index = textBox1.Text.IndexOf(textBox10.Text, textBox1.SelectionStart - textBox1.SelectionLength);

                if (index > -1)
                {
                    textBox1.Focus();
                    textBox1.Select(index, textBox10.Text.Length);
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("not found");
                textBox10.Focus();
            }
            else
                MessageBox.Show("ادخل النص المراد البحث عنه");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                if (textBox11.Text.Trim() != null)
                    textBox1.SelectedText = textBox11.Text.Trim();
                else
                    MessageBox.Show("ادخل النص الجديد");
            }
            else
                MessageBox.Show("حدد النص المراد تعديله");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != null)
            {
                textBox3.Text = textBox1.SelectedText.Length.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
                if (textBox1.Text[i] != ' ')
                    x++;
            textBox8.Text = x.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int x = 0;
            char[] temp = textBox1.SelectedText.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] != ' ')
                    x++;
            textBox9.Text = x.ToString();
        }
    }
}
