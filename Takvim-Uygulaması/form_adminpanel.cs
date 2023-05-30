using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takvim_Uygulaması.controller;
using Takvim_Uygulaması.enumaration;
using Takvim_Uygulaması.model;

namespace Takvim_Uygulaması
{
    public partial class form_adminpanel : Form
    {
        Controller controller=new Controller();
        public form_adminpanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_datetime.Text = DateTime.Now.ToString();
        }

        private void form_adminpanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            getallusers();
        }
        private void getallusers() 
        {
            List<user> user=controller.getallusers();
            dataGridView1.DataSource = user;
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tc.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_insertadmin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tc.Text)) 
            {
                string tc = txt_tc.Text;
                DialogResult dialogResult = MessageBox.Show(txt_tc.Text + " Kimlik numaralı kullanıcı admin olarak atanacaktır onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginStatus result = controller.assignadmin(tc);
                    if (result == LoginStatus.başarılı)
                        MessageBox.Show(txt_tc.Text + " Kimlik numaralı kullanıcı admin olarak atanmıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if(result==LoginStatus.başarısız)
                        MessageBox.Show(txt_tc.Text + " Kimlik numaralı kullanıcı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                getallusers();
            }
            else
                MessageBox.Show("Tc boş bırakılamaz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            
        }

        private void btn_removeuser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tc.Text)) 
            {
                string tc = txt_tc.Text;
                DialogResult dialogResult = MessageBox.Show(txt_tc.Text + " Tc numaralı kullanıcı silinecektir onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginStatus result = controller.removeusers(tc);
                    if (result == LoginStatus.başarılı)
                        MessageBox.Show(txt_tc.Text + " Tc numaralı kullanıcı silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (result == LoginStatus.başarısız)
                        MessageBox.Show(txt_tc.Text + " Tc numaralı kullanıcı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                getallusers();
            }
            else
                MessageBox.Show("Tc boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void lbl_datetime_Click(object sender, EventArgs e)
        {

        }
    }
}
