namespace Takvim_Uygulaması
{
    partial class form_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_user));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_top_date = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_showevent = new System.Windows.Forms.Button();
            this.lbl_tarihsaat = new System.Windows.Forms.Label();
            this.lbl_deneme = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_alarm = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_event = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_removeevent = new System.Windows.Forms.Button();
            this.btn_updateevent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_out = new System.Windows.Forms.Button();
            this.txt_removetc = new System.Windows.Forms.MaskedTextBox();
            this.txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_removepassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_removeusername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.RichTextBox();
            this.txt_passwordagain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_removeusers = new System.Windows.Forms.Button();
            this.btn_updateusers = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1774, 1171);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.lbl_top_date);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btn_back);
            this.tabPage1.Controls.Add(this.btn_next);
            this.tabPage1.Controls.Add(this.daycontainer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1766, 1129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Takvim";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbl_top_date
            // 
            this.lbl_top_date.AutoSize = true;
            this.lbl_top_date.Font = new System.Drawing.Font("High Tower Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_date.Location = new System.Drawing.Point(711, 14);
            this.lbl_top_date.Name = "lbl_top_date";
            this.lbl_top_date.Size = new System.Drawing.Size(236, 48);
            this.lbl_top_date.TabIndex = 10;
            this.lbl_top_date.Text = "Month Year";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1534, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 41);
            this.label20.TabIndex = 9;
            this.label20.Text = "Pazar";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1270, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 41);
            this.label21.TabIndex = 8;
            this.label21.Text = "Cumartesi";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1047, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 41);
            this.label22.TabIndex = 7;
            this.label22.Text = "Cuma";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(792, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 41);
            this.label17.TabIndex = 6;
            this.label17.Text = "Persembe";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(543, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 41);
            this.label18.TabIndex = 5;
            this.label18.Text = "Çarsamba";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(336, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 41);
            this.label16.TabIndex = 4;
            this.label16.Text = "Salı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 41);
            this.label14.TabIndex = 3;
            this.label14.Text = "Pazartesi";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1319, 1060);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(154, 58);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1552, 1058);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(154, 58);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "İleri";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // daycontainer
            // 
            this.daycontainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.daycontainer.Location = new System.Drawing.Point(25, 126);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1710, 918);
            this.daycontainer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.Controls.Add(this.btn_showevent);
            this.tabPage2.Controls.Add(this.lbl_tarihsaat);
            this.tabPage2.Controls.Add(this.lbl_deneme);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txt_alarm);
            this.tabPage2.Controls.Add(this.txt_id);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_event);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_removeevent);
            this.tabPage2.Controls.Add(this.btn_updateevent);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1766, 1129);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Olaylar";
            // 
            // btn_showevent
            // 
            this.btn_showevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_showevent.Location = new System.Drawing.Point(766, 576);
            this.btn_showevent.Name = "btn_showevent";
            this.btn_showevent.Size = new System.Drawing.Size(457, 120);
            this.btn_showevent.TabIndex = 17;
            this.btn_showevent.Text = "Görüntüle";
            this.btn_showevent.UseVisualStyleBackColor = true;
            this.btn_showevent.Click += new System.EventHandler(this.btn_showevent_Click);
            // 
            // lbl_tarihsaat
            // 
            this.lbl_tarihsaat.AutoSize = true;
            this.lbl_tarihsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarihsaat.Location = new System.Drawing.Point(1318, 1006);
            this.lbl_tarihsaat.Name = "lbl_tarihsaat";
            this.lbl_tarihsaat.Size = new System.Drawing.Size(85, 40);
            this.lbl_tarihsaat.TabIndex = 16;
            this.lbl_tarihsaat.Text = "saat";
            this.lbl_tarihsaat.Click += new System.EventHandler(this.lbl_tarihsaat_Click);
            // 
            // lbl_deneme
            // 
            this.lbl_deneme.AutoSize = true;
            this.lbl_deneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deneme.Location = new System.Drawing.Point(1471, 954);
            this.lbl_deneme.Name = "lbl_deneme";
            this.lbl_deneme.Size = new System.Drawing.Size(81, 40);
            this.lbl_deneme.TabIndex = 15;
            this.lbl_deneme.Text = "isim";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(1298, 954);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 40);
            this.label15.TabIndex = 14;
            this.label15.Text = "Kullanıcı :";
            // 
            // txt_alarm
            // 
            this.txt_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alarm.Location = new System.Drawing.Point(200, 883);
            this.txt_alarm.Mask = "00/00/0000 90:00";
            this.txt_alarm.Name = "txt_alarm";
            this.txt_alarm.Size = new System.Drawing.Size(290, 44);
            this.txt_alarm.TabIndex = 13;
            this.txt_alarm.ValidatingType = typeof(System.DateTime);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(200, 579);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(95, 44);
            this.txt_id.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 883);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alarm ";
            // 
            // txt_event
            // 
            this.txt_event.Location = new System.Drawing.Point(200, 667);
            this.txt_event.Name = "txt_event";
            this.txt_event.Size = new System.Drawing.Size(479, 173);
            this.txt_event.TabIndex = 5;
            this.txt_event.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Olay,toplantı:";
            // 
            // btn_removeevent
            // 
            this.btn_removeevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_removeevent.Location = new System.Drawing.Point(766, 903);
            this.btn_removeevent.Name = "btn_removeevent";
            this.btn_removeevent.Size = new System.Drawing.Size(457, 127);
            this.btn_removeevent.TabIndex = 3;
            this.btn_removeevent.Text = "Sil";
            this.btn_removeevent.UseVisualStyleBackColor = true;
            this.btn_removeevent.Click += new System.EventHandler(this.btn_removeevent_Click);
            // 
            // btn_updateevent
            // 
            this.btn_updateevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_updateevent.Location = new System.Drawing.Point(766, 736);
            this.btn_updateevent.Name = "btn_updateevent";
            this.btn_updateevent.Size = new System.Drawing.Size(457, 122);
            this.btn_updateevent.TabIndex = 2;
            this.btn_updateevent.Text = "Güncelle";
            this.btn_updateevent.UseVisualStyleBackColor = true;
            this.btn_updateevent.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1670, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.btn_out);
            this.tabPage3.Controls.Add(this.txt_removetc);
            this.tabPage3.Controls.Add(this.txt_tc);
            this.tabPage3.Controls.Add(this.txt_removepassword);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt_removeusername);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_telefon);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_adres);
            this.tabPage3.Controls.Add(this.txt_passwordagain);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txt_email);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txt_password);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt_username);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btn_removeusers);
            this.tabPage3.Controls.Add(this.btn_updateusers);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1766, 1129);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_out
            // 
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_out.Location = new System.Drawing.Point(958, 860);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(649, 176);
            this.btn_out.TabIndex = 54;
            this.btn_out.Text = "Çıkış Yap";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // txt_removetc
            // 
            this.txt_removetc.BackColor = System.Drawing.Color.Black;
            this.txt_removetc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_removetc.ForeColor = System.Drawing.Color.Lime;
            this.txt_removetc.Location = new System.Drawing.Point(1257, 127);
            this.txt_removetc.Mask = "00000000000";
            this.txt_removetc.Name = "txt_removetc";
            this.txt_removetc.Size = new System.Drawing.Size(350, 57);
            this.txt_removetc.TabIndex = 53;
            // 
            // txt_tc
            // 
            this.txt_tc.BackColor = System.Drawing.Color.Black;
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.ForeColor = System.Drawing.Color.Lime;
            this.txt_tc.Location = new System.Drawing.Point(414, 93);
            this.txt_tc.Mask = "00000000000";
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(350, 57);
            this.txt_tc.TabIndex = 52;
            // 
            // txt_removepassword
            // 
            this.txt_removepassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_removepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_removepassword.ForeColor = System.Drawing.Color.Lime;
            this.txt_removepassword.Location = new System.Drawing.Point(1256, 316);
            this.txt_removepassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_removepassword.Name = "txt_removepassword";
            this.txt_removepassword.Size = new System.Drawing.Size(351, 53);
            this.txt_removepassword.TabIndex = 49;
            this.txt_removepassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(950, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 46);
            this.label6.TabIndex = 50;
            this.label6.Text = "Şifre:";
            // 
            // txt_removeusername
            // 
            this.txt_removeusername.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_removeusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_removeusername.ForeColor = System.Drawing.Color.Lime;
            this.txt_removeusername.Location = new System.Drawing.Point(1256, 230);
            this.txt_removeusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_removeusername.Name = "txt_removeusername";
            this.txt_removeusername.Size = new System.Drawing.Size(351, 53);
            this.txt_removeusername.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(950, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 46);
            this.label7.TabIndex = 51;
            this.label7.Text = "Kullanıcı adı:";
            // 
            // txt_telefon
            // 
            this.txt_telefon.BackColor = System.Drawing.Color.Black;
            this.txt_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.ForeColor = System.Drawing.Color.Lime;
            this.txt_telefon.Location = new System.Drawing.Point(414, 556);
            this.txt_telefon.Mask = "(999) 000-0000";
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(351, 53);
            this.txt_telefon.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(111, 556);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 46);
            this.label10.TabIndex = 47;
            this.label10.Text = "Telefon no:";
            // 
            // txt_adres
            // 
            this.txt_adres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_adres.Location = new System.Drawing.Point(414, 658);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(351, 124);
            this.txt_adres.TabIndex = 32;
            this.txt_adres.Text = "";
            // 
            // txt_passwordagain
            // 
            this.txt_passwordagain.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_passwordagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_passwordagain.ForeColor = System.Drawing.Color.Lime;
            this.txt_passwordagain.Location = new System.Drawing.Point(414, 374);
            this.txt_passwordagain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_passwordagain.Name = "txt_passwordagain";
            this.txt_passwordagain.Size = new System.Drawing.Size(351, 53);
            this.txt_passwordagain.TabIndex = 36;
            this.txt_passwordagain.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(108, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 46);
            this.label8.TabIndex = 45;
            this.label8.Text = "Şifre Tekrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(111, 658);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 46);
            this.label5.TabIndex = 35;
            this.label5.Text = "Adres:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.ForeColor = System.Drawing.Color.Lime;
            this.txt_email.Location = new System.Drawing.Point(414, 460);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(351, 53);
            this.txt_email.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(107, 456);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 46);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email:";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.ForeColor = System.Drawing.Color.Lime;
            this.txt_password.Location = new System.Drawing.Point(413, 278);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(351, 53);
            this.txt_password.TabIndex = 34;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(107, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 46);
            this.label11.TabIndex = 39;
            this.label11.Text = "Şifre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(950, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 46);
            this.label12.TabIndex = 42;
            this.label12.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(108, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 46);
            this.label9.TabIndex = 42;
            this.label9.Text = "TC:";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.ForeColor = System.Drawing.Color.Lime;
            this.txt_username.Location = new System.Drawing.Point(413, 192);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(351, 53);
            this.txt_username.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(107, 192);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 46);
            this.label13.TabIndex = 42;
            this.label13.Text = "Kullanıcı adı:";
            // 
            // btn_removeusers
            // 
            this.btn_removeusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_removeusers.Location = new System.Drawing.Point(958, 416);
            this.btn_removeusers.Name = "btn_removeusers";
            this.btn_removeusers.Size = new System.Drawing.Size(649, 176);
            this.btn_removeusers.TabIndex = 1;
            this.btn_removeusers.Text = "Hesabımı Sil";
            this.btn_removeusers.UseVisualStyleBackColor = true;
            this.btn_removeusers.Click += new System.EventHandler(this.btn_removeusers_Click);
            // 
            // btn_updateusers
            // 
            this.btn_updateusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_updateusers.Location = new System.Drawing.Point(119, 860);
            this.btn_updateusers.Name = "btn_updateusers";
            this.btn_updateusers.Size = new System.Drawing.Size(646, 177);
            this.btn_updateusers.TabIndex = 0;
            this.btn_updateusers.Text = "Güncelle";
            this.btn_updateusers.UseVisualStyleBackColor = true;
            this.btn_updateusers.Click += new System.EventHandler(this.btn_updateusers_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1782, 1191);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takvimim";
            this.Load += new System.EventHandler(this.form_user_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_removeevent;
        private System.Windows.Forms.Button btn_updateevent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_removeusers;
        private System.Windows.Forms.Button btn_updateusers;
        private System.Windows.Forms.MaskedTextBox txt_telefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txt_adres;
        private System.Windows.Forms.TextBox txt_passwordagain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_removepassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_removeusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_removetc;
        private System.Windows.Forms.MaskedTextBox txt_tc;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.MaskedTextBox txt_alarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lbl_deneme;
        private System.Windows.Forms.Label lbl_tarihsaat;
        private System.Windows.Forms.Button btn_showevent;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label lbl_top_date;
    }
}