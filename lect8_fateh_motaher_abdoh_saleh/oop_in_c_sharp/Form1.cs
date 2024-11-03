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
{   public partial class Form1 : Form
    {
    public Form1 (){
            InitializeComponent();
            }
       

        
        }
    class person
    {
        public string firstname;
        public string lastname;
        public person()
        {
            firstname = "";
            lastname = "";
        }
        public person(string f, string l)
        {
            firstname = f;
            lastname = l;
        }
    }
    class student:person
        {
            private int id;
            public string name;
            static string gender;
            public static string address;
            public student()
            {
                this.id = 0;
                this.name = "";
                gender = "";
                address = "";
            }
            public student(int i, string n, string g, string add)
            {
                this.id = i;
                this.name = n;

                gender = g;
                address = add;
                 MessageBox.Show(id.ToString() + name + gender + address);
            }
            public void setid(int i) { this.id = i; }
            public void setname(string n) { this.name = n; }
            public static void setgenderandaddres(string add, string g) { address = add; gender = g; }
            public int getid() { return id; }
            public string getname() { return name; }
            public static string getgender() { return gender; }
            public static string getaddress() { return address; }
        public void setfirstnamelastname(string f, string l)
        {
            firstname = f;
            lastname = l;
        }
        public string getfullname() { return firstname + "" +lastname; }

        }
    //student s = new student(1, "ali", "male", "ibb");
    //int id = s.getid();
    //MessageBox.Show("the gender is:" + student.getgender());
    //        MessageBox.Show("the address is:" + student.getaddress());
    //        s.setfirstnamelastname("fateh", "alrhman");
    //        MessageBox.Show(s.firstname + "  " + s.lastname);
    //        MessageBox.Show("the id is :" + id.ToString());
 
}
