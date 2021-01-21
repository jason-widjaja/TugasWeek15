
namespace Tugas_week_15
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
            this.Nama = new System.Windows.Forms.Label();
            this.boxitem = new System.Windows.Forms.TextBox();
            this.Kategori = new System.Windows.Forms.Label();
            this.radiomakanan = new System.Windows.Forms.RadioButton();
            this.radiominuman = new System.Windows.Forms.RadioButton();
            this.input = new System.Windows.Forms.Button();
            this.listBoxKiri = new System.Windows.Forms.ListBox();
            this.listBoxKanan = new System.Windows.Forms.ListBox();
            this.inputKanan = new System.Windows.Forms.Button();
            this.hapusKanan = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.checkMakanan = new System.Windows.Forms.CheckBox();
            this.checkMinuman = new System.Windows.Forms.CheckBox();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(49, 34);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(58, 13);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama Item";
            this.Nama.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxitem
            // 
            this.boxitem.Location = new System.Drawing.Point(136, 34);
            this.boxitem.Name = "boxitem";
            this.boxitem.Size = new System.Drawing.Size(147, 20);
            this.boxitem.TabIndex = 1;
            this.boxitem.TextChanged += new System.EventHandler(this.boxitem_TextChanged);
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Location = new System.Drawing.Point(49, 85);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(46, 13);
            this.Kategori.TabIndex = 2;
            this.Kategori.Text = "Kategori";
            // 
            // radiomakanan
            // 
            this.radiomakanan.AutoSize = true;
            this.radiomakanan.Location = new System.Drawing.Point(136, 85);
            this.radiomakanan.Name = "radiomakanan";
            this.radiomakanan.Size = new System.Drawing.Size(70, 17);
            this.radiomakanan.TabIndex = 3;
            this.radiomakanan.TabStop = true;
            this.radiomakanan.Text = "Makanan";
            this.radiomakanan.UseVisualStyleBackColor = true;
            // 
            // radiominuman
            // 
            this.radiominuman.AutoSize = true;
            this.radiominuman.Location = new System.Drawing.Point(213, 85);
            this.radiominuman.Name = "radiominuman";
            this.radiominuman.Size = new System.Drawing.Size(68, 17);
            this.radiominuman.TabIndex = 4;
            this.radiominuman.TabStop = true;
            this.radiominuman.Text = "Minuman";
            this.radiominuman.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(136, 129);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 5;
            this.input.Text = "Input";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // listBoxKiri
            // 
            this.listBoxKiri.FormattingEnabled = true;
            this.listBoxKiri.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Roti",
            "Keju",
            "Daging Giling",
            "Teh",
            "Bir"});
            this.listBoxKiri.Location = new System.Drawing.Point(69, 188);
            this.listBoxKiri.Name = "listBoxKiri";
            this.listBoxKiri.Size = new System.Drawing.Size(120, 212);
            this.listBoxKiri.TabIndex = 6;
            this.listBoxKiri.SelectedIndexChanged += new System.EventHandler(this.listBoxKiri_SelectedIndexChanged);
            // 
            // listBoxKanan
            // 
            this.listBoxKanan.FormattingEnabled = true;
            this.listBoxKanan.Location = new System.Drawing.Point(319, 188);
            this.listBoxKanan.Name = "listBoxKanan";
            this.listBoxKanan.Size = new System.Drawing.Size(120, 212);
            this.listBoxKanan.TabIndex = 7;
            // 
            // inputKanan
            // 
            this.inputKanan.Location = new System.Drawing.Point(220, 206);
            this.inputKanan.Name = "inputKanan";
            this.inputKanan.Size = new System.Drawing.Size(63, 23);
            this.inputKanan.TabIndex = 8;
            this.inputKanan.Text = ">";
            this.inputKanan.UseVisualStyleBackColor = true;
            this.inputKanan.Click += new System.EventHandler(this.inputKanan_Click);
            // 
            // hapusKanan
            // 
            this.hapusKanan.Location = new System.Drawing.Point(220, 246);
            this.hapusKanan.Name = "hapusKanan";
            this.hapusKanan.Size = new System.Drawing.Size(63, 23);
            this.hapusKanan.TabIndex = 9;
            this.hapusKanan.Text = "X";
            this.hapusKanan.UseVisualStyleBackColor = true;
            this.hapusKanan.Click += new System.EventHandler(this.hapusKanan_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filter.Controls.Add(this.checkMinuman);
            this.Filter.Controls.Add(this.checkMakanan);
            this.Filter.Location = new System.Drawing.Point(195, 295);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(118, 93);
            this.Filter.TabIndex = 10;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // checkMakanan
            // 
            this.checkMakanan.AutoSize = true;
            this.checkMakanan.Location = new System.Drawing.Point(7, 20);
            this.checkMakanan.Name = "checkMakanan";
            this.checkMakanan.Size = new System.Drawing.Size(71, 17);
            this.checkMakanan.TabIndex = 0;
            this.checkMakanan.Text = "Makanan";
            this.checkMakanan.UseVisualStyleBackColor = true;
            this.checkMakanan.CheckedChanged += new System.EventHandler(this.checkMakanan_CheckedChanged);
            // 
            // checkMinuman
            // 
            this.checkMinuman.AutoSize = true;
            this.checkMinuman.Location = new System.Drawing.Point(7, 55);
            this.checkMinuman.Name = "checkMinuman";
            this.checkMinuman.Size = new System.Drawing.Size(69, 17);
            this.checkMinuman.TabIndex = 1;
            this.checkMinuman.Text = "Minuman";
            this.checkMinuman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 551);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.hapusKanan);
            this.Controls.Add(this.inputKanan);
            this.Controls.Add(this.listBoxKanan);
            this.Controls.Add(this.listBoxKiri);
            this.Controls.Add(this.input);
            this.Controls.Add(this.radiominuman);
            this.Controls.Add(this.radiomakanan);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.boxitem);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.TextBox boxitem;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.RadioButton radiomakanan;
        private System.Windows.Forms.RadioButton radiominuman;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.ListBox listBoxKiri;
        private System.Windows.Forms.ListBox listBoxKanan;
        private System.Windows.Forms.Button inputKanan;
        private System.Windows.Forms.Button hapusKanan;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.CheckBox checkMinuman;
        private System.Windows.Forms.CheckBox checkMakanan;
    }
}

