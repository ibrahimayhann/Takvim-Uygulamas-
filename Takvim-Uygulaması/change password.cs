using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takvim_Uygulaması.controller;
using Takvim_Uygulaması.enumaration;

namespace Takvim_Uygulaması
{
    public partial class change_password : Form
    {
        int code;
        public change_password()
        {
            InitializeComponent();
        }

        private void btn_mailgonder_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emailadres = controller.checkmailaddres(txt_username.Text);
            if (emailadres == txt_mail.Text)
            {
                Random rnd = new Random();
                code = rnd.Next(111111, 999999);
                MailAddress mailalan = new MailAddress(txt_mail.Text);
                MailAddress mailgonderen = new MailAddress("ayhandeveloper@hotmail.com", "developer ayhan");
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(mailalan);
                mesaj.From = mailgonderen;
                mesaj.Subject = "şifre değiştirme";
                mesaj.Body = "şifrenizi değiştirmek için doğrulama kodunuz:" + code;
                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("ayhandeveloper@hotmail.com", "Ayhan63.a");
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                MessageBox.Show("Doğrulama kodu gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen email adresinizi doğru giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_authcode_Click(object sender, EventArgs e)
        {
            if (txt_dogrulamakodu.Text == code.ToString())
            {
                gbox_sifreyenile.Visible = true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodunu yanlış girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (txt_yenisifre.Text == txt_yenisifretekrar.Text)
            {
                LoginStatus result = controller.changepassword(txt_username.Text, txt_yenisifre.Text);
                if (result == LoginStatus.başarılı)
                {
                    MessageBox.Show("Şifre değiştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değildir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void change_password_Load(object sender, EventArgs e)
        {
            gbox_sifreyenile.Visible = false;
        }

        private void lbl_backlogin_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
