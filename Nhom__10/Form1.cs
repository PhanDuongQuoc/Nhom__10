using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ListViewItem listItem = new ListViewItem(txtmasv.Text);
            listItem.SubItems.Add(txthoten.Text);
            listItem.SubItems.Add(dtpngaysinh.Text);
            listItem.SubItems.Add(cblophoc.Text);
            listView1.Items.Add(listItem);
        }

        private void dtpngaysinh_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                listView1.Items.Remove(selectedItem);
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                if (selectedItem.SubItems.Count >= 4)
                {
                 
                    selectedItem.SubItems[0].Text = txtmasv.Text;
                    selectedItem.SubItems[1].Text = txthoten.Text;
                    selectedItem.SubItems[2].Text = dtpngaysinh.Text;
                    selectedItem.SubItems[3].Text = cblophoc.Text;
                }
           
            }
            else
            {
             
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnkluu.Enabled = false;
        }
    }
}