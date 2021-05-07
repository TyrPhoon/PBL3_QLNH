using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public int a;
        private void button1_Click(object sender, EventArgs e)
        {
            fHome f = new fHome();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



//private void button1_Click(object sender, EventArgs e)
//{
//    fHome f = new fHome();
//    this.Hide();
//    f.ShowDialog();
//    this.Show();
//}

//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//{
//    if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
//    {
//        e.Cancel = true;
//    }
//}

//private void butExit_Click(object sender, EventArgs e)
//{
//    this.Close();
//}
//    }
//}
//public int a;
//private void button1_Click(object sender, EventArgs e)
//{
//    fHome f = new fHome();
//    this.Hide();
//    f.ShowDialog();
//    this.Show();
//}

//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//{
//    if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
//    {
//        e.Cancel = true;
//    }
//}

//private void butExit_Click(object sender, EventArgs e)
//{
//    this.Close();
//}

//private void button1_Click(object sender, EventArgs e)
//{
//    fHome f = new fHome();
//    this.Hide();
//    f.ShowDialog();
//    this.Show();
//}

//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//{
//    if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
//    {
//        e.Cancel = true;
//    }
//}

//private void butExit_Click(object sender, EventArgs e)
//{
//    this.Close();
//}
//    }
//}
//public int a;
//private void button1_Click(object sender, EventArgs e)
//{
//    fHome f = new fHome();
//    this.Hide();
//    f.ShowDialog();
//    this.Show();
//}

//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//{
//    if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
//    {
//        e.Cancel = true;
//    }
//}

//private void butExit_Click(object sender, EventArgs e)
//{
//    this.Close();
//}