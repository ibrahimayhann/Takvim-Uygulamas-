using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim_Uygulaması
{
    public partial class UserControldays : UserControl
    {
        public UserControldays()
        {
            InitializeComponent();
        }

        public static string static_day;
        private void UserControldays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numdays) 
        {
            lbl_days.Text = numdays.ToString();//boşluk sildim
        }

        private void UserControldays_Click(object sender, EventArgs e)
        {
            static_day=lbl_days.Text;
            form_event form_Event = new form_event();
            form_Event.Show(); 
        }
    }
}
