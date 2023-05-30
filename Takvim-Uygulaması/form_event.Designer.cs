namespace Takvim_Uygulaması
{
    partial class form_event
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
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_event = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_saveevent = new System.Windows.Forms.Button();
            this.btn_alarmekle = new System.Windows.Forms.Button();
            this.txt_hour = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_event_username = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_date.Location = new System.Drawing.Point(324, 83);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(270, 44);
            this.txt_date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih:";
            // 
            // txt_event
            // 
            this.txt_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_event.Location = new System.Drawing.Point(324, 162);
            this.txt_event.Name = "txt_event";
            this.txt_event.Size = new System.Drawing.Size(270, 124);
            this.txt_event.TabIndex = 2;
            this.txt_event.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Olay/Toplantı:";
            // 
            // btn_saveevent
            // 
            this.btn_saveevent.Font = new System.Drawing.Font("MS Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveevent.Location = new System.Drawing.Point(82, 559);
            this.btn_saveevent.Name = "btn_saveevent";
            this.btn_saveevent.Size = new System.Drawing.Size(512, 74);
            this.btn_saveevent.TabIndex = 4;
            this.btn_saveevent.Text = "Kaydet";
            this.btn_saveevent.UseVisualStyleBackColor = true;
            this.btn_saveevent.Click += new System.EventHandler(this.btn_saveevent_Click);
            // 
            // btn_alarmekle
            // 
            this.btn_alarmekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_alarmekle.Location = new System.Drawing.Point(324, 367);
            this.btn_alarmekle.Name = "btn_alarmekle";
            this.btn_alarmekle.Size = new System.Drawing.Size(270, 74);
            this.btn_alarmekle.TabIndex = 5;
            this.btn_alarmekle.Text = "Hatırlatıcı oluştur";
            this.btn_alarmekle.UseVisualStyleBackColor = true;
            this.btn_alarmekle.Click += new System.EventHandler(this.btn_alarmekle_Click);
            // 
            // txt_hour
            // 
            this.txt_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hour.Location = new System.Drawing.Point(97, 393);
            this.txt_hour.Mask = "00:00";
            this.txt_hour.Name = "txt_hour";
            this.txt_hour.Size = new System.Drawing.Size(104, 48);
            this.txt_hour.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txt_hour, "Hatırlatıcı oluşturmak istemiyorsanız burayı boş bırakın.");
            this.txt_hour.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saat ↓";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(94, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı:";
            // 
            // lbl_event_username
            // 
            this.lbl_event_username.AutoSize = true;
            this.lbl_event_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_event_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_event_username.Location = new System.Drawing.Point(231, 670);
            this.lbl_event_username.Name = "lbl_event_username";
            this.lbl_event_username.Size = new System.Drawing.Size(148, 32);
            this.lbl_event_username.TabIndex = 10;
            this.lbl_event_username.Text = "isimgelcek";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date.Location = new System.Drawing.Point(94, 733);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(153, 40);
            this.lbl_date.TabIndex = 11;
            this.lbl_date.Text = "taih saat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 807);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_event_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hour);
            this.Controls.Add(this.btn_alarmekle);
            this.Controls.Add(this.btn_saveevent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_event);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_date);
            this.Name = "form_event";
            this.Text = "Olay/Toplantı Olştur";
            this.Load += new System.EventHandler(this.form_event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_event;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_saveevent;
        private System.Windows.Forms.Button btn_alarmekle;
        private System.Windows.Forms.MaskedTextBox txt_hour;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_event_username;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Timer timer1;
    }
}