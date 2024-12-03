using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kích hoạt FullRowSelect
            lvNhanvien.FullRowSelect = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem(txtSTT.Text);
            item1.SubItems.Add(txtMa.Text);
            item1.SubItems.Add(txtTen.Text);
            lvNhanvien.Items.Add(item1);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0) ;
            {
                ListViewItem item1 = lvNhanvien.SelectedItems[0];
                item1.SubItems[0].Text = txtSTT.Text;
                item1.SubItems[1].Text = txtMa.Text;
                item1.SubItems[2].Text = txtTen.Text;
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                while (lvNhanvien.SelectedItems.Count > 0)
                {
                    Console.WriteLine(lvNhanvien.SelectedItems[0].Index);
                    lvNhanvien.Items.RemoveAt(lvNhanvien.SelectedItems[0].Index);
                }
            }
        }

        private void lvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
