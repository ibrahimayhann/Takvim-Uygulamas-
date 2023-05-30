using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takvim_Uygulaması.controller;
using Takvim_Uygulaması.enumaration;
using Takvim_Uygulaması.model;

namespace Takvim_Uygulaması
{
    public partial class form_user : Form
    {
        public form_user()
        {
            InitializeComponent();
        }
        List<events> alarmList;

        private void form_user_Load(object sender, EventArgs e)
        {
            timer1.Start();
            displaDays();
            // alarm kodları
            Controller controller = new Controller();
            string kullanıcı = "ibrahim";
            alarmList = controller.getevent(kullanıcı);
            //
        }

        private void btn_updateusers_Click(object sender, EventArgs e)
        {
            user user = new user();
            Controller controller = new Controller();
            user.tc=txt_tc.Text;
            user.username = txt_username.Text;
            if (txt_password.Text == txt_passwordagain.Text)
                user.password = txt_password.Text;
            else
                MessageBox.Show("Şifreler Eşleşmiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            user.email = txt_email.Text;
            user.telefon = txt_telefon.Text;
            user.adres = txt_adres.Text;
            LoginStatus result = controller.updateusers(user);
            if (result == LoginStatus.başarılı)
                MessageBox.Show("Bilgiler güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == LoginStatus.başarısız)
                MessageBox.Show("Bilgiler güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (result == LoginStatus.eksikparametre)
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("else düştü.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }//hesap güncelleme 

        private void btn_removeusers_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (!string.IsNullOrEmpty(txt_removetc.Text) && !string.IsNullOrEmpty(txt_removeusername.Text) && !string.IsNullOrEmpty(txt_removepassword.Text))
            {
                string tc = txt_removetc.Text;
                DialogResult dialogResult = MessageBox.Show(txt_removetc.Text + " Tc numaralı kullanıcı silinecektir onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginStatus result = controller.removeusers(tc);
                    if (result == LoginStatus.başarılı)
                        MessageBox.Show(txt_removetc.Text + " Tc numaralı kullanıcı silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (result == LoginStatus.başarısız)
                        MessageBox.Show(txt_removetc.Text + " Tc numaralı kullanıcı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Sağ taraftaki tüm alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }//hesap silme 

        private void btn_out_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }//çıkış yap 



        private void btn_update_Click(object sender, EventArgs e) 
        {
            Controller controller = new Controller();
            events events = new events();
            if (!string.IsNullOrEmpty(txt_id.Text))
                events.id = int.Parse(txt_id.Text);
            else
                MessageBox.Show("id boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            events.olay = txt_event.Text;
            if (txt_alarm.Text != null  && txt_alarm.Text != "  .  .       :")
                events.alarm = DateTime.Parse(txt_alarm.Text); 
            else
                MessageBox.Show("Olay tarihi boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            events.tarih = DateTime.Parse(lbl_tarihsaat.Text);
            events.username = lbl_deneme.Text;
            LoginStatus result = controller.updatevent(events);
            if (result == LoginStatus.başarılı)
                MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result == LoginStatus.başarısız)
                MessageBox.Show("Bilgiler güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (result == LoginStatus.eksikparametre)
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("else düştü.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }//olay güncelleme

        private void lbl_tarihsaat_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; // Timer'ı geçici olarak durdur

            lbl_tarihsaat.Text = DateTime.Now.ToString();
            DateTime currentTime = DateTime.Now;

            // Alarm kontrolü ve işlemler
            List<events> alarmsToBeRemoved = new List<events>();

            foreach (events alarm in alarmList)
            {
                if (currentTime >= alarm.alarm)
                {
                    // Alarm zamanı gelmiş, işlemler yapılabilir
                    string message = $"Alarm: {alarm.olay}";
                    MessageBox.Show(message, "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SoundPlayer sound=new SoundPlayer();
                    sound.SoundLocation = @"C:\Users\ihali\Downloads\Alarm-Sesleri-zilsesiindir.com-3 (online-audio-converter.com).wav";
                    sound.Play();
                    // Alarm işaretlenerek kaldırılacak
                    alarmsToBeRemoved.Add(alarm);
                }
            }

            // İşlenen alarmları listeden kaldır
            foreach (events alarmToRemove in alarmsToBeRemoved)
            {
                alarmList.Remove(alarmToRemove);
            }

            timer1.Enabled = true; // Timer'ı tekrar etkinleştir
        }

        private void btn_removeevent_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (txt_id.Text != null && txt_id.Text != "")
            {
                int id = int.Parse(txt_id.Text);
                string username=lbl_deneme.Text;
                DialogResult dialogResult = MessageBox.Show(txt_id.Text + " id numaralı olay silinecektir onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginStatus result = controller.removevent(id, username);
                    if (result == LoginStatus.başarılı)
                        MessageBox.Show(txt_id + " id numaralı olay silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (result == LoginStatus.başarısız)
                        MessageBox.Show(txt_id + " id numaralı olay bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("id boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }//olay silme

        private void btn_showevent_Click(object sender, EventArgs e)
        {

            Controller controller = new Controller();
            List<events> events = controller.getevent(lbl_deneme.Text);
            dataGridView1.DataSource = events;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //takvim kodları
        int month, year;
        public static int static_month,static_year;
        private void displaDays()
        {
            
            DateTime suan = DateTime.Now;
            static_month = suan.Month;
            static_year = suan.Year;
            month = suan.Month;
            year = suan.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_top_date.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));//+1 i sildim sonra hata çıkarsa aklında olsun
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_top_date.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));//+1 i sildim sonra hata çıkarsa aklında olsun
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if(month > 12) 
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_top_date.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));//+1 i sildim sonra hata çıkarsa aklında olsun
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if (month <1)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_top_date.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));//+1 i sildim sonra hata çıkarsa aklında olsun
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add((ucdays));
            }
        }

        




















        //takvim kodları

    }
}

