using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leaning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStr.connnectsql();
             DataTable loaddata = ConnectionStr.executsql("SELECT * FROM customer");
            datagv.DataSource = loaddata;
            datagv.Columns[0].HeaderText = "ID";
            datagv.Columns[1].HeaderText = "NAME";
            datagv.Columns[2].HeaderText = "SURNAME";
            datagv.Columns[3].HeaderText = "NICKNAME";
            datagv.Columns[4].HeaderText = "AGE";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtid.Text  == ""||txtname.Text==""||txtnick.Text==""||txtage.Text==""||txtsurname.Text=="")
            {
                MessageBox.Show("กรุณากรอกให้ครบ","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else {
                ConnectionStr.executsql("INSERT INTO customer(ID,name,surname,nickname,age) " +
                "VALUES ('" + txtid.Text + "','" + txtname.Text + "','" + txtsurname.Text + "','" + txtnick.Text + "','" + txtage.Text + "')");
                MessageBox.Show("บันทึกข้อมูลแล้ว", "บันแล้วสัส", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            

        }

        private void datagv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }


}
