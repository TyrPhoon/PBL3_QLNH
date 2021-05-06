using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNH.Entity;
using QLNH.BLL;
//asdfsdafasdfasdfasdfasdfasfasfasfasfsafsadfasdfasdfsdfas
// safasdf
// asdf
// asd
// f
// asd
// fas
// f
// as
// df
// asdf

namespace QLNH
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

		private void button7_Click(object sender, EventArgs e)
		{

            dataGridView2.DataSource = BLL_ThucAn.Instance.GetThucAn();
            dataGridView2.Columns["Danhmucthucan"].Visible = false;
            dataGridView2.Columns["HoaDonchitiets"].Visible = false;
        }

		private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            DataGridViewSelectedRowCollection data = dataGridView2.SelectedRows;
            textBox20.Text = data[0].Cells["id"].Value.ToString();
            textBox19.Text = data[0].Cells["ten"].Value.ToString();
            numericUpDown2.Value = Convert.ToInt32(data[0].Cells["gia"].Value.ToString());
		}
	}
}




//private void button7_Click(object sender, EventArgs e)
//{

//    dataGridView2.DataSource = BLL_ThucAn.Instance.GetThucAn();
//    dataGridView2.Columns["Danhmucthucan"].Visible = false;
//    dataGridView2.Columns["HoaDonchitiets"].Visible = false;
//}

//private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
//{
//    DataGridViewSelectedRowCollection data = dataGridView2.SelectedRows;
//    textBox20.Text = data[0].Cells["id"].Value.ToString();
//    textBox19.Text = data[0].Cells["ten"].Value.ToString();
//    numericUpDown2.Value = Convert.ToInt32(data[0].Cells["gia"].Value.ToString());
//}
//	}
//}