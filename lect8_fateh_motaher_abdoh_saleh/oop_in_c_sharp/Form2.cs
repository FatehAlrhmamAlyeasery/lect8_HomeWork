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
    public partial class Form2 : Form
    {
        Button b;
        Label l;
        TextBox t;
        ListBox lst;
        public Form2()
        {
            InitializeComponent();
            b = new Button();
            l = new Label();
            t = new TextBox();
            lst = new ListBox();
            b.Click += bclick;
            visual();
            design();
        }
        public Form2(string btntxt,string lbltxt)
        {
            InitializeComponent();
            b = new Button();
            l = new Label();
            t = new TextBox();
            lst = new ListBox();
            b.Text = btntxt;
            l.Text = lbltxt;
            b.Click += bclick;
        }
        private void set(string btntxt,string lbltxt)
        {
            b.Text = btntxt;
            l.Text = lbltxt;
        }
        public void bclick(object s,EventArgs e)
        {
            lst.Items.Add(t.Text);
        }
        public void design()
        {
            b.Top = 30;b.Left = 25;lst.Top = 60;
            t.Top = 10;l.Left = 110;l.Top = 10;
            t.Left = lst.Left = 10;
        }
        public void visual()
        {
            this.Controls.Add(b);
            this.Controls.Add(t);
            this.Controls.Add(l);
            this.Controls.Add(lst);
        }
        public string getbtntxt() { return b.Text; }
        private void Button1_Click(object sender,EventArgs e)
        {
            Form2 g = new Form2();
            g.visual();
            g.design();
            g.Show();
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {
         

        }
    }
}
