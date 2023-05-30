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
using Takvim_Uygulaması.controller;
using Takvim_Uygulaması.enumaration;
using Takvim_Uygulaması.model;

namespace Takvim_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string kullanıcı;
        private void btn_login_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            user result=controller.login(txt_username.Text, txt_password.Text);
            if (result != null && result.status == LoginStatus.başarılı && result.yetki == "admin")
            {
                form_adminpanel form_Adminpanel = new form_adminpanel();
                form_Adminpanel.Show();
                this.Hide();
            }
            else if (result != null && result.status == LoginStatus.başarılı && result.yetki == "user")
            {
              
                form_user form_Userr = new form_user();
                
                form_Userr.Show();
                this.Hide();
                form_Userr.lbl_deneme.Text=txt_username.Text;
                kullanıcı = txt_username.Text;
                
                
            }
            else if (result != null && result.status == LoginStatus.başarısız)
            {
                MessageBox.Show("Böyle bir kullanıcı yoktur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void lbl_sifremiunuttum_Click(object sender, EventArgs e)
        {
            change_password change_Password=new change_password();
            change_Password.Show();
            this.Hide();
        }

        private void lbl_kayıtol_Click(object sender, EventArgs e)
        {
            form_kaydol form_Kaydol = new form_kaydol();
            form_Kaydol.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
