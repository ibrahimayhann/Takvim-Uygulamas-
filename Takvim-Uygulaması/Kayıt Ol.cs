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
    public partial class form_kaydol : Form
    {
        public form_kaydol()
        {
            InitializeComponent();
        }

        private void form_kaydol_Load(object sender, EventArgs e)
        {
           txt_yetki.Enabled = false;
        }

        private void lbl_backlogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            user user= new user();
            Controller controller = new Controller();
            user.name = txt_name.Text;
            user.surname = txt_surname.Text;
            user.username = txt_username.Text;
            user.email = txt_email.Text;
            user.yetki = txt_yetki.Text;
            user.tc=txt_tc.Text;
            user.telefon = txt_telefon.Text;
            user.adres = txt_adres.Text;
            if(txt_password.Text==txt_passwordagain.Text)
                user.password = txt_password.Text;
            else
                MessageBox.Show("Şifreler eşleşmiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LoginStatus result = controller.insertuser(user);
            if(result==LoginStatus.başarılı)
                MessageBox.Show("Kayıt başarıyla tamamlanmmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(result==LoginStatus.başarısız)
                MessageBox.Show("Kayıt oluşturulurken hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(result==LoginStatus.eksikparametre)
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("çözemdim", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }
    }
}
