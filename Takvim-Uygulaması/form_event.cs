using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takvim_Uygulaması.controller;
using Takvim_Uygulaması.enumaration;
using Takvim_Uygulaması.model;

namespace Takvim_Uygulaması
{
    public partial class form_event : Form
    {
        public form_event()
        {
            InitializeComponent();
        }

        private void form_event_Load(object sender, EventArgs e)
        {
            txt_date.Text = UserControldays.static_day + "/" + form_user.static_month +"/"+ form_user.static_year;
            txt_date.Enabled = false;
            //int day = intUserControldays.static_day;
            lbl_event_username.Text= Form1.kullanıcı.ToString();
            timer1.Start();
           
        }
        int sayac=0;
        private void btn_alarmekle_Click(object sender, EventArgs e)
        {
            if(sayac==0 && txt_hour.Text!= "  :") 
            {
                string hour = " " + txt_hour.Text;
                txt_date.Text += hour;
                sayac++;
            }
            
           
            
            
        }

        private void btn_saveevent_Click(object sender, EventArgs e)
        {
            events events = new events();
            Controller controller = new Controller();
           
            events.username = lbl_event_username.Text;
            events.olay=txt_event.Text;
            events.tarih=DateTime.Parse( lbl_date.Text);
        
            events.alarm = DateTime.Parse(txt_date.Text);
            LoginStatus result=controller.insertevent(events);
            if(result==LoginStatus.başarılı)
                MessageBox.Show("Kaydedilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(result==LoginStatus.başarısız)
                MessageBox.Show("Kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Eksik parametre hatası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString();
        }
    }
}
