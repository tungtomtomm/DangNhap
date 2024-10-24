using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DangNhap
{
    public partial class Form1 : Form
    {
        string tentaikhoan = "admin";
        string matkhau = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            if (Kiemtrandangnhap(textBox1.Text, textBox2.Text))
                {
                MessageBox.Show("Dang nhap thanh cong");
                }
            else
            MessageBox.Show("Dang nhap khong thanh cong");
            
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        public bool Kiemtrandangnhap(string tentaikhoan, string matkhau) 
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = '*';
        }
    }
}
