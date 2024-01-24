namespace Projekat_ONT
{
    partial class FormProizvodi
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
            panel1 = new Panel();
            CijenaProizvodaTB = new TextBox();
            KolicinaProizvodaTB = new TextBox();
            NazivProizvodaTB = new TextBox();
            IdProizvodaTB = new TextBox();
            katcmb = new ComboBox();
            label6 = new Label();
            proDGV = new DataGridView();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)proDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(CijenaProizvodaTB);
            panel1.Controls.Add(KolicinaProizvodaTB);
            panel1.Controls.Add(NazivProizvodaTB);
            panel1.Controls.Add(IdProizvodaTB);
            panel1.Controls.Add(katcmb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(proDGV);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(135, 61);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 752);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // CijenaProizvodaTB
            // 
            CijenaProizvodaTB.Location = new Point(136, 320);
            CijenaProizvodaTB.Margin = new Padding(3, 4, 3, 4);
            CijenaProizvodaTB.Name = "CijenaProizvodaTB";
            CijenaProizvodaTB.Size = new Size(169, 27);
            CijenaProizvodaTB.TabIndex = 20;
            // 
            // KolicinaProizvodaTB
            // 
            KolicinaProizvodaTB.Location = new Point(136, 259);
            KolicinaProizvodaTB.Margin = new Padding(3, 4, 3, 4);
            KolicinaProizvodaTB.Name = "KolicinaProizvodaTB";
            KolicinaProizvodaTB.Size = new Size(169, 27);
            KolicinaProizvodaTB.TabIndex = 19;
            // 
            // NazivProizvodaTB
            // 
            NazivProizvodaTB.Location = new Point(136, 187);
            NazivProizvodaTB.Margin = new Padding(3, 4, 3, 4);
            NazivProizvodaTB.Name = "NazivProizvodaTB";
            NazivProizvodaTB.Size = new Size(169, 27);
            NazivProizvodaTB.TabIndex = 18;
            // 
            // IdProizvodaTB
            // 
            IdProizvodaTB.Location = new Point(136, 119);
            IdProizvodaTB.Margin = new Padding(3, 4, 3, 4);
            IdProizvodaTB.Name = "IdProizvodaTB";
            IdProizvodaTB.Size = new Size(169, 27);
            IdProizvodaTB.TabIndex = 17;
            // 
            // katcmb
            // 
            katcmb.ForeColor = Color.OrangeRed;
            katcmb.FormattingEnabled = true;
            katcmb.Items.AddRange(new object[] { "ADMIN", "TRGOVAC" });
            katcmb.Location = new Point(136, 373);
            katcmb.Margin = new Padding(3, 4, 3, 4);
            katcmb.Name = "katcmb";
            katcmb.Size = new Size(169, 28);
            katcmb.TabIndex = 14;
            katcmb.Text = "Izaberite kategoriju";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 373);
            label6.Name = "label6";
            label6.Size = new Size(115, 29);
            label6.TabIndex = 13;
            label6.Text = "Kategorija";
            // 
            // proDGV
            // 
            proDGV.BackgroundColor = Color.White;
            proDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proDGV.Location = new Point(376, 119);
            proDGV.Margin = new Padding(3, 4, 3, 4);
            proDGV.Name = "proDGV";
            proDGV.RowHeadersWidth = 51;
            proDGV.RowTemplate.Height = 25;
            proDGV.Size = new Size(442, 604);
            proDGV.TabIndex = 12;
            proDGV.CellContentClick += proDGV_CellContentClick;
            // 
            // button7
            // 
            button7.BackColor = Color.Snow;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.OrangeRed;
            button7.Location = new Point(243, 447);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 61);
            button7.TabIndex = 11;
            button7.Text = "IZBRIŠI";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Snow;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.OrangeRed;
            button6.Location = new Point(135, 447);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 61);
            button6.TabIndex = 10;
            button6.Text = "UREDI";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Snow;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(32, 447);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 61);
            button4.TabIndex = 9;
            button4.Text = "DODAJ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 320);
            label5.Name = "label5";
            label5.Size = new Size(83, 29);
            label5.TabIndex = 8;
            label5.Text = "CIJENA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 259);
            label4.Name = "label4";
            label4.Size = new Size(107, 29);
            label4.TabIndex = 6;
            label4.Text = "KOLIČINA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 187);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 4;
            label3.Text = "NAZIV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 119);
            label2.Name = "label2";
            label2.Size = new Size(34, 29);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 33);
            label1.Name = "label1";
            label1.Size = new Size(338, 33);
            label1.TabIndex = 0;
            label1.Text = "UPRAVLJANJE PROIZVODIMA";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(17, 61);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "TRGOVCI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(17, 123);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 2;
            button2.Text = "KATEGORIJE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.OrangeRed;
            button3.Location = new Point(17, 189);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(98, 31);
            button3.TabIndex = 3;
            button3.Text = "PROIZVODI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.OrangeRed;
            button5.Location = new Point(942, -5);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(47, 63);
            button5.TabIndex = 5;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(17, 788);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 6;
            label7.Text = "ODJAVI SE";
            label7.Click += label7_Click;
            // 
            // FormProizvodi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 1057);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProizvodi";
            Text = "FormProizvodi";
            Load += FormProizvodi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)proDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button6;
        private Button button4;
        private Label label6;
        private DataGridView proDGV;
        private Button button7;
        private ComboBox katcmb;
        private TextBox CijenaProizvodaTB;
        private TextBox KolicinaProizvodaTB;
        private TextBox NazivProizvodaTB;
        private TextBox IdProizvodaTB;
        private Label label7;
    }
}