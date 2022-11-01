namespace WinFormsAppAlan_Hesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKenar = new System.Windows.Forms.TextBox();
            this.textBoxKisaKenar = new System.Windows.Forms.TextBox();
            this.textBoxUzunKenar = new System.Windows.Forms.TextBox();
            this.textBoxYariCap = new System.Windows.Forms.TextBox();
            this.labelKare = new System.Windows.Forms.Label();
            this.labelDiktortgen = new System.Windows.Forms.Label();
            this.labelDaire = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(218, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alan Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 118);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(248, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geometri Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.labelKare);
            this.panel2.Controls.Add(this.textBoxKenar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-5, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 162);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.labelDiktortgen);
            this.panel3.Controls.Add(this.textBoxUzunKenar);
            this.panel3.Controls.Add(this.textBoxKisaKenar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(281, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 162);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.labelDaire);
            this.panel4.Controls.Add(this.textBoxYariCap);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(556, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 162);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kenar(m):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kısa Kenar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Uzun Kenar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yarı Çap:";
            // 
            // textBoxKenar
            // 
            this.textBoxKenar.Location = new System.Drawing.Point(130, 92);
            this.textBoxKenar.Name = "textBoxKenar";
            this.textBoxKenar.Size = new System.Drawing.Size(100, 23);
            this.textBoxKenar.TabIndex = 6;
            this.textBoxKenar.Text = "0";
            // 
            // textBoxKisaKenar
            // 
            this.textBoxKisaKenar.Location = new System.Drawing.Point(112, 76);
            this.textBoxKisaKenar.Name = "textBoxKisaKenar";
            this.textBoxKisaKenar.Size = new System.Drawing.Size(100, 23);
            this.textBoxKisaKenar.TabIndex = 3;
            this.textBoxKisaKenar.Text = "0";
            // 
            // textBoxUzunKenar
            // 
            this.textBoxUzunKenar.Location = new System.Drawing.Point(112, 105);
            this.textBoxUzunKenar.Name = "textBoxUzunKenar";
            this.textBoxUzunKenar.Size = new System.Drawing.Size(100, 23);
            this.textBoxUzunKenar.TabIndex = 4;
            this.textBoxUzunKenar.Text = "0";
            // 
            // textBoxYariCap
            // 
            this.textBoxYariCap.Location = new System.Drawing.Point(91, 95);
            this.textBoxYariCap.Name = "textBoxYariCap";
            this.textBoxYariCap.Size = new System.Drawing.Size(100, 23);
            this.textBoxYariCap.TabIndex = 2;
            this.textBoxYariCap.Text = "0";
            // 
            // labelKare
            // 
            this.labelKare.AutoSize = true;
            this.labelKare.Location = new System.Drawing.Point(130, 132);
            this.labelKare.Name = "labelKare";
            this.labelKare.Size = new System.Drawing.Size(13, 15);
            this.labelKare.TabIndex = 6;
            this.labelKare.Text = "0";
            // 
            // labelDiktortgen
            // 
            this.labelDiktortgen.AutoSize = true;
            this.labelDiktortgen.Location = new System.Drawing.Point(118, 140);
            this.labelDiktortgen.Name = "labelDiktortgen";
            this.labelDiktortgen.Size = new System.Drawing.Size(13, 15);
            this.labelDiktortgen.TabIndex = 5;
            this.labelDiktortgen.Text = "0";
            // 
            // labelDaire
            // 
            this.labelDaire.AutoSize = true;
            this.labelDaire.Location = new System.Drawing.Point(103, 137);
            this.labelDaire.Name = "labelDaire";
            this.labelDaire.Size = new System.Drawing.Size(13, 15);
            this.labelDaire.TabIndex = 3;
            this.labelDaire.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Alan Hesaplayıcı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label labelKare;
        private TextBox textBoxKenar;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label labelDiktortgen;
        private TextBox textBoxUzunKenar;
        private TextBox textBoxKisaKenar;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label labelDaire;
        private TextBox textBoxYariCap;
        private Label label5;
        private PictureBox pictureBox3;
    }
}