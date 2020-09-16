namespace InternetPaketi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delatebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrzina = new System.Windows.Forms.ComboBox();
            this.cbUgovor = new System.Windows.Forms.ComboBox();
            this.tfAdresa = new System.Windows.Forms.TextBox();
            this.tfPrezime = new System.Windows.Forms.TextBox();
            this.tfIme = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delatebtn);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBrzina);
            this.groupBox1.Controls.Add(this.cbUgovor);
            this.groupBox1.Controls.Add(this.tfAdresa);
            this.groupBox1.Controls.Add(this.tfPrezime);
            this.groupBox1.Controls.Add(this.tfIme);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // delatebtn
            // 
            this.delatebtn.Location = new System.Drawing.Point(278, 187);
            this.delatebtn.Name = "delatebtn";
            this.delatebtn.Size = new System.Drawing.Size(75, 35);
            this.delatebtn.TabIndex = 11;
            this.delatebtn.Text = "Izbrisi";
            this.delatebtn.UseVisualStyleBackColor = true;
            this.delatebtn.Click += new System.EventHandler(this.delatebtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(175, 187);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 35);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "Spasi";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Brzina protoka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ugovor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // cbBrzina
            // 
            this.cbBrzina.FormattingEnabled = true;
            this.cbBrzina.Location = new System.Drawing.Point(103, 124);
            this.cbBrzina.Name = "cbBrzina";
            this.cbBrzina.Size = new System.Drawing.Size(172, 21);
            this.cbBrzina.TabIndex = 4;
            // 
            // cbUgovor
            // 
            this.cbUgovor.FormattingEnabled = true;
            this.cbUgovor.Location = new System.Drawing.Point(103, 97);
            this.cbUgovor.Name = "cbUgovor";
            this.cbUgovor.Size = new System.Drawing.Size(172, 21);
            this.cbUgovor.TabIndex = 3;
            this.cbUgovor.SelectedIndexChanged += new System.EventHandler(this.cbUgovor_SelectedIndexChanged);
            // 
            // tfAdresa
            // 
            this.tfAdresa.Location = new System.Drawing.Point(103, 71);
            this.tfAdresa.Name = "tfAdresa";
            this.tfAdresa.Size = new System.Drawing.Size(172, 20);
            this.tfAdresa.TabIndex = 2;
            // 
            // tfPrezime
            // 
            this.tfPrezime.Location = new System.Drawing.Point(103, 45);
            this.tfPrezime.Name = "tfPrezime";
            this.tfPrezime.Size = new System.Drawing.Size(172, 20);
            this.tfPrezime.TabIndex = 1;
            // 
            // tfIme
            // 
            this.tfIme.Location = new System.Drawing.Point(103, 19);
            this.tfIme.Name = "tfIme";
            this.tfIme.Size = new System.Drawing.Size(172, 20);
            this.tfIme.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1138, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delatebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrzina;
        private System.Windows.Forms.ComboBox cbUgovor;
        private System.Windows.Forms.TextBox tfAdresa;
        private System.Windows.Forms.TextBox tfPrezime;
        private System.Windows.Forms.TextBox tfIme;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

