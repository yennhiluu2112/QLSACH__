using QLSach.DTO;
using QLSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSach
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            Show();
        }
        public void SetCBB()
        {
            cbbTG.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbTG.Items.AddRange(BLL.BLL.Instance.GetListCBBItem().ToArray());
            cbbTG.SelectedIndex = 0;

            cbbSort.Items.Add(new CBBItem { Value = 0, Text = "Ten Sach" });
            cbbSort.Items.Add(new CBBItem { Value = 1, Text = "NXB" });
            cbbSort.SelectedIndex = 0;
        }
        public void Show()
        {
            int ID_TG = ((CBBItem)cbbTG.SelectedItem).Value;
            dataGridView1.DataSource = BLL.BLL.Instance.Show_Sach(ID_TG);
            dataGridView1.Columns["MaSach"].Visible = false;
            dataGridView1.Columns["ID_TacGia"].Visible = false;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        { 
            Show();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                List<string> LMS = new List<string>();
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    LMS.Add(dataGridView1.SelectedRows[i].Cells["MaSach"].Value.ToString());
                }
                BLL.BLL.Instance.Delete_Sach(LMS);
                Show();
            }
            else
            {
                MessageBox.Show("Vui long chon sach can xoa");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<string> ListMaSach = new List<string>(); //lay danh sach ma sach dang co tren datagridview ra 
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                ListMaSach.Add(i.Cells["MaSach"].Value.ToString());
            }

            if (dataGridView1.DataSource != null)
            {
                List<Sach> s = BLL.BLL.Instance.GetListDGV(ListMaSach); //xong  get list sach bang ma sach
                string a = textBox1.Text;
                dataGridView1.DataSource = null;
                List<Sach> sa = BLL.BLL.Instance.Search_Sach(s, a);
                dataGridView1.DataSource = BLL.BLL.Instance.Show_Sach_After(sa);
                if (dataGridView1.Columns.Count >1)
                {
                    dataGridView1.Columns["MaSach"].Visible = false;
                    dataGridView1.Columns["ID_TacGia"].Visible = false;
                }    
                else
                {
                    MessageBox.Show("Khong tim thay");
                }     
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Sach sach_edit = BLL.BLL.Instance.GetSachWithID(dataGridView1.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString());
            Form2 f = new Form2(sach_edit.MaSach);
            f.ShowInfo(sach_edit);
            f.editsach += new Form2.Del(BLL.BLL.Instance.Edit_Sach);
            f.show += new Form2.MyDel(Show);
            f.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.show += new Form2.MyDel(Show);
            f.Show();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            List<Sach> list = new List<Sach>();
            string a = ((CBBItem)cbbSort.SelectedItem).Text;
            list = BLL.BLL.Instance.Sort_Sach(a);
            dataGridView1.DataSource = BLL.BLL.Instance.Show_Sach_After(list);
        }
    }
}
