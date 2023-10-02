namespace AplikasiInputDataMahasiswa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNim = new TextBox();
            txtNama = new TextBox();
            txtKelas = new TextBox();
            txtNilai = new TextBox();
            btnSimpan = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            lvwMahasiswa = new ListView();
            btnHapus = new Button();
            btnTampilkanData = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Nim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 81);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Kelas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 110);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Nilai";
            // 
            // txtNim
            // 
            txtNim.Location = new Point(86, 18);
            txtNim.Name = "txtNim";
            txtNim.Size = new Size(100, 23);
            txtNim.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(86, 49);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(143, 23);
            txtNama.TabIndex = 5;
            // 
            // txtKelas
            // 
            txtKelas.Location = new Point(86, 78);
            txtKelas.Name = "txtKelas";
            txtKelas.Size = new Size(100, 23);
            txtKelas.TabIndex = 6;
            // 
            // txtNilai
            // 
            txtNilai.Location = new Point(86, 107);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(100, 23);
            txtNilai.TabIndex = 7;
            txtNilai.KeyPress += txtNilai_KeyPress;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(29, 158);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(111, 158);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvwMahasiswa);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnTampilkanData);
            groupBox1.Location = new Point(235, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 417);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ Daftar Mahasiswa ]";
            // 
            // lvwMahasiswa
            // 
            lvwMahasiswa.Location = new Point(6, 57);
            lvwMahasiswa.Name = "lvwMahasiswa";
            lvwMahasiswa.Size = new Size(541, 354);
            lvwMahasiswa.TabIndex = 2;
            lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            lvwMahasiswa.SelectedIndexChanged += lvwMahasiswa_SelectedIndexChanged;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(117, 22);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 1;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTampilkanData
            // 
            btnTampilkanData.Location = new Point(6, 22);
            btnTampilkanData.Name = "btnTampilkanData";
            btnTampilkanData.Size = new Size(105, 23);
            btnTampilkanData.TabIndex = 0;
            btnTampilkanData.Text = "Tampilkan Data";
            btnTampilkanData.UseVisualStyleBackColor = true;
            btnTampilkanData.Click += btnTampilkanData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnSimpan);
            Controls.Add(txtNilai);
            Controls.Add(txtKelas);
            Controls.Add(txtNama);
            Controls.Add(txtNim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Input Data Mahasiswa";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNim;
        private TextBox txtNama;
        private TextBox txtKelas;
        private TextBox txtNilai;
        private Button btnSimpan;
        private Button btnReset;
        private GroupBox groupBox1;
        private ListView lvwMahasiswa;
        private Button btnHapus;
        private Button btnTampilkanData;
    }
}