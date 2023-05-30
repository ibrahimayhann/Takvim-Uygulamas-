namespace Takvim_Uygulaması
{
    partial class form_adminpanel
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
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_insertadmin = new System.Windows.Forms.Button();
            this.btn_removeuser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_tc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.Location = new System.Drawing.Point(1255, 941);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(287, 50);
            this.lbl_datetime.TabIndex = 12;
            this.lbl_datetime.Text = "Tarih ve saat";
            this.lbl_datetime.Click += new System.EventHandler(this.lbl_datetime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1628, 511);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_insertadmin
            // 
            this.btn_insertadmin.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_insertadmin.Location = new System.Drawing.Point(46, 673);
            this.btn_insertadmin.Name = "btn_insertadmin";
            this.btn_insertadmin.Size = new System.Drawing.Size(287, 88);
            this.btn_insertadmin.TabIndex = 14;
            this.btn_insertadmin.Text = "Admin olarak ata";
            this.btn_insertadmin.UseVisualStyleBackColor = true;
            this.btn_insertadmin.Click += new System.EventHandler(this.btn_insertadmin_Click);
            // 
            // btn_removeuser
            // 
            this.btn_removeuser.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_removeuser.Location = new System.Drawing.Point(382, 673);
            this.btn_removeuser.Name = "btn_removeuser";
            this.btn_removeuser.Size = new System.Drawing.Size(287, 88);
            this.btn_removeuser.TabIndex = 15;
            this.btn_removeuser.Text = "Kullanıcıyı Sil";
            this.btn_removeuser.UseVisualStyleBackColor = true;
            this.btn_removeuser.Click += new System.EventHandler(this.btn_removeuser_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(723, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 88);
            this.button1.TabIndex = 16;
            this.button1.Text = "Giriş ekranına dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(135, 563);
            this.txt_tc.Mask = "00000000000";
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(213, 44);
            this.txt_tc.TabIndex = 17;
            // 
            // form_adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1663, 1006);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_removeuser);
            this.Controls.Add(this.btn_insertadmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.label1);
            this.Name = "form_adminpanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.form_adminpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_insertadmin;
        private System.Windows.Forms.Button btn_removeuser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txt_tc;
    }
}