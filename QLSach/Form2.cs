using QLSach.DTO;
using QLSach.BLL;
using System;
using System.Windows.Forms;

namespace QLSach
{

    public partial class Form2 : Form
    {
        private string MaSach;
        public delegate void MyDel();
        public MyDel show { get; set; } 

        public delegate void Del(Sach s);
        public Del editsach { get; set; }
        public Del ShowInfo { get; set; }
        public Form2(string MaSach)
        {
            this.MaSach = MaSach;
            InitializeComponent();
            ShowInfo += new Del(Show_Info);
            SetCBB();
        }
        public void SetCBB()
        {
            cbbTG.Items.AddRange(BLL.BLL.Instance.GetListCBBItem().ToArray());
            cbbTG.SelectedIndex = 0;
        }
        public void Show_Info(Sach s)
        {
            textBox1.Text = s.MaSach;
            textBox2.Text = s.TenSach;
            dateTimePicker1.Value = s.NXB;
            if (s.TinhTrang)
            {
                rbCon.Checked = true;
            }
            else rbHet.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                Sach s = new Sach()
                {
                    MaSach = textBox1.Text,
                    TenSach = textBox2.Text,
                    NXB = dateTimePicker1.Value.Date,
                    TinhTrang = (rbCon.Checked) ? true : false,
                    TG = BLL.BLL.Instance.GetTGWithID(((CBBItem)cbbTG.SelectedItem).Value)
                };
            if (this.MaSach == "")
            {
                // add
                if (BLL.BLL.Instance.Is_EsxitID(s.MaSach))
                {
                    MessageBox.Show("Trung");
                    return;
                }
                else
                {
                    BLL.BLL.Instance.Add_Sach(s);
                }
            }
            else {
                //edit
                if (editsach != null)
                {
                    editsach(s); 
                }
            }
            if (show!=null)
            { 
                show(); 
            }
            this.Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
