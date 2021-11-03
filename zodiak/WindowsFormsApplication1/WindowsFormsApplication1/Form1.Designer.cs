namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttempat = new System.Windows.Forms.TextBox();
            this.dtptanggal = new System.Windows.Forms.DateTimePicker();
            this.rblaki = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbperempuan = new System.Windows.Forms.RadioButton();
            this.btnview = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.rcbview = new System.Windows.Forms.RichTextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempat, Tanggal  Lahir";
            // 
            // txttempat
            // 
            this.txttempat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttempat.Location = new System.Drawing.Point(223, 66);
            this.txttempat.Name = "txttempat";
            this.txttempat.Size = new System.Drawing.Size(243, 28);
            this.txttempat.TabIndex = 7;
            this.txttempat.TextChanged += new System.EventHandler(this.txttempat_TextChanged);
            // 
            // dtptanggal
            // 
            this.dtptanggal.CustomFormat = "dd-MMMM-yyyy";
            this.dtptanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptanggal.Location = new System.Drawing.Point(487, 66);
            this.dtptanggal.Name = "dtptanggal";
            this.dtptanggal.Size = new System.Drawing.Size(226, 28);
            this.dtptanggal.TabIndex = 8;
            this.dtptanggal.ValueChanged += new System.EventHandler(this.dtptanggal_ValueChanged);
            // 
            // rblaki
            // 
            this.rblaki.AutoSize = true;
            this.rblaki.Location = new System.Drawing.Point(223, 111);
            this.rblaki.Name = "rblaki";
            this.rblaki.Size = new System.Drawing.Size(86, 21);
            this.rblaki.TabIndex = 10;
            this.rblaki.TabStop = true;
            this.rblaki.Text = "Laki-Laki";
            this.rblaki.UseVisualStyleBackColor = true;
            this.rblaki.CheckedChanged += new System.EventHandler(this.rblaki_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jenis Kelamin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbperempuan
            // 
            this.rbperempuan.AutoSize = true;
            this.rbperempuan.Location = new System.Drawing.Point(380, 111);
            this.rbperempuan.Name = "rbperempuan";
            this.rbperempuan.Size = new System.Drawing.Size(102, 21);
            this.rbperempuan.TabIndex = 12;
            this.rbperempuan.TabStop = true;
            this.rbperempuan.Text = "Perempuan";
            this.rbperempuan.UseVisualStyleBackColor = true;
            this.rbperempuan.CheckedChanged += new System.EventHandler(this.rbperempuan_CheckedChanged);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(223, 149);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(86, 34);
            this.btnview.TabIndex = 21;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(380, 149);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(86, 34);
            this.btnclear.TabIndex = 22;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // rcbview
            // 
            this.rcbview.Location = new System.Drawing.Point(26, 204);
            this.rcbview.Name = "rcbview";
            this.rcbview.Size = new System.Drawing.Size(687, 191);
            this.rcbview.TabIndex = 23;
            this.rcbview.Text = "";
            this.rcbview.TextChanged += new System.EventHandler(this.rcbview_TextChanged);
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(223, 22);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(243, 28);
            this.txtnama.TabIndex = 5;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(747, 413);
            this.Controls.Add(this.rcbview);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.rbperempuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rblaki);
            this.Controls.Add(this.dtptanggal);
            this.Controls.Add(this.txttempat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Zodiak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttempat;
        private System.Windows.Forms.DateTimePicker dtptanggal;
        private System.Windows.Forms.RadioButton rblaki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbperempuan;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.RichTextBox rcbview;
        private System.Windows.Forms.TextBox txtnama;
    }
}

