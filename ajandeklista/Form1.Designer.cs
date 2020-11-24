namespace ajandeklista
{
    partial class Ajándékok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajándékok));
            this.ajandekListBox = new System.Windows.Forms.ListBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_bolt = new System.Windows.Forms.TextBox();
            this.button_ajandekHozzaadas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ajandekTorles = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_reszletek = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nev_modosit = new System.Windows.Forms.TextBox();
            this.button_modositas = new System.Windows.Forms.Button();
            this.textBox_bolt_modosit = new System.Windows.Forms.TextBox();
            this.label_id_modosit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajandekListBox
            // 
            this.ajandekListBox.FormattingEnabled = true;
            this.ajandekListBox.Location = new System.Drawing.Point(8, 19);
            this.ajandekListBox.Name = "ajandekListBox";
            this.ajandekListBox.Size = new System.Drawing.Size(208, 212);
            this.ajandekListBox.TabIndex = 0;
            this.ajandekListBox.SelectedIndexChanged += new System.EventHandler(this.ajandekListBox_SelectedIndexChanged);
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(6, 40);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev.TabIndex = 1;
            // 
            // textBox_bolt
            // 
            this.textBox_bolt.Location = new System.Drawing.Point(6, 83);
            this.textBox_bolt.Name = "textBox_bolt";
            this.textBox_bolt.Size = new System.Drawing.Size(100, 20);
            this.textBox_bolt.TabIndex = 2;
            // 
            // button_ajandekHozzaadas
            // 
            this.button_ajandekHozzaadas.Location = new System.Drawing.Point(6, 113);
            this.button_ajandekHozzaadas.Name = "button_ajandekHozzaadas";
            this.button_ajandekHozzaadas.Size = new System.Drawing.Size(100, 23);
            this.button_ajandekHozzaadas.TabIndex = 3;
            this.button_ajandekHozzaadas.Text = "Hozzáadás";
            this.button_ajandekHozzaadas.UseVisualStyleBackColor = true;
            this.button_ajandekHozzaadas.Click += new System.EventHandler(this.button_ajandekHozzaadas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.button_ajandekHozzaadas);
            this.groupBox1.Controls.Add(this.textBox_bolt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új ajándék";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bolt:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ajandekTorles);
            this.groupBox2.Controls.Add(this.ajandekListBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 272);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajándékok";
            // 
            // button_ajandekTorles
            // 
            this.button_ajandekTorles.Location = new System.Drawing.Point(8, 238);
            this.button_ajandekTorles.Name = "button_ajandekTorles";
            this.button_ajandekTorles.Size = new System.Drawing.Size(75, 23);
            this.button_ajandekTorles.TabIndex = 1;
            this.button_ajandekTorles.Text = "Törlés";
            this.button_ajandekTorles.UseVisualStyleBackColor = true;
            this.button_ajandekTorles.Click += new System.EventHandler(this.button_ajandekTorles_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_reszletek);
            this.groupBox3.Location = new System.Drawing.Point(246, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajándék részletei";
            // 
            // label_reszletek
            // 
            this.label_reszletek.AutoSize = true;
            this.label_reszletek.Location = new System.Drawing.Point(7, 19);
            this.label_reszletek.Name = "label_reszletek";
            this.label_reszletek.Size = new System.Drawing.Size(0, 13);
            this.label_reszletek.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_id_modosit);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox_nev_modosit);
            this.groupBox4.Controls.Add(this.button_modositas);
            this.groupBox4.Controls.Add(this.textBox_bolt_modosit);
            this.groupBox4.Location = new System.Drawing.Point(246, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 151);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajándék szerkesztése";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bolt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Név:";
            // 
            // textBox_nev_modosit
            // 
            this.textBox_nev_modosit.Location = new System.Drawing.Point(6, 40);
            this.textBox_nev_modosit.Name = "textBox_nev_modosit";
            this.textBox_nev_modosit.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev_modosit.TabIndex = 1;
            // 
            // button_modositas
            // 
            this.button_modositas.Location = new System.Drawing.Point(6, 113);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(100, 23);
            this.button_modositas.TabIndex = 3;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = true;
            this.button_modositas.Click += new System.EventHandler(this.button_modositas_Click);
            // 
            // textBox_bolt_modosit
            // 
            this.textBox_bolt_modosit.Location = new System.Drawing.Point(6, 83);
            this.textBox_bolt_modosit.Name = "textBox_bolt_modosit";
            this.textBox_bolt_modosit.Size = new System.Drawing.Size(100, 20);
            this.textBox_bolt_modosit.TabIndex = 2;
            // 
            // label_id_modosit
            // 
            this.label_id_modosit.AutoSize = true;
            this.label_id_modosit.Location = new System.Drawing.Point(42, 24);
            this.label_id_modosit.Name = "label_id_modosit";
            this.label_id_modosit.Size = new System.Drawing.Size(0, 13);
            this.label_id_modosit.TabIndex = 7;
            this.label_id_modosit.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ajandeklista.Properties.Resources.Daco_4145831;
            this.pictureBox1.Location = new System.Drawing.Point(140, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Ajándékok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajándékok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajándékok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ajandekListBox;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_bolt;
        private System.Windows.Forms.Button button_ajandekHozzaadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ajandekTorles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_reszletek;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nev_modosit;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.TextBox textBox_bolt_modosit;
        private System.Windows.Forms.Label label_id_modosit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

