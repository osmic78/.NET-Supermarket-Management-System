namespace Projekat_ONT
{
    partial class FormaKategorije
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
            OpisKategorijeTb = new TextBox();
            NazivKategorijeTb = new TextBox();
            IdKategorijeTb = new TextBox();
            katGDV = new DataGridView();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)katGDV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(OpisKategorijeTb);
            panel1.Controls.Add(NazivKategorijeTb);
            panel1.Controls.Add(IdKategorijeTb);
            panel1.Controls.Add(katGDV);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(98, 51);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 755);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // OpisKategorijeTb
            // 
            OpisKategorijeTb.Location = new Point(165, 259);
            OpisKategorijeTb.Margin = new Padding(3, 4, 3, 4);
            OpisKategorijeTb.Name = "OpisKategorijeTb";
            OpisKategorijeTb.Size = new Size(133, 27);
            OpisKategorijeTb.TabIndex = 15;
            // 
            // NazivKategorijeTb
            // 
            NazivKategorijeTb.Location = new Point(165, 191);
            NazivKategorijeTb.Margin = new Padding(3, 4, 3, 4);
            NazivKategorijeTb.Name = "NazivKategorijeTb";
            NazivKategorijeTb.Size = new Size(133, 27);
            NazivKategorijeTb.TabIndex = 14;
            // 
            // IdKategorijeTb
            // 
            IdKategorijeTb.Location = new Point(165, 123);
            IdKategorijeTb.Margin = new Padding(3, 4, 3, 4);
            IdKategorijeTb.Name = "IdKategorijeTb";
            IdKategorijeTb.Size = new Size(133, 27);
            IdKategorijeTb.TabIndex = 13;
            // 
            // katGDV
            // 
            katGDV.BackgroundColor = Color.White;
            katGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            katGDV.Location = new Point(378, 123);
            katGDV.Margin = new Padding(3, 4, 3, 4);
            katGDV.Name = "katGDV";
            katGDV.RowHeadersWidth = 51;
            katGDV.RowTemplate.Height = 25;
            katGDV.Size = new Size(442, 595);
            katGDV.TabIndex = 12;
            katGDV.CellContentClick += katGDV_CellContentClick;
            // 
            // button7
            // 
            button7.BackColor = Color.Snow;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.OrangeRed;
            button7.Location = new Point(232, 344);
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
            button6.Location = new Point(123, 344);
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
            button4.Location = new Point(21, 344);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 61);
            button4.TabIndex = 9;
            button4.Text = "DODAJ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 259);
            label4.Name = "label4";
            label4.Size = new Size(59, 29);
            label4.TabIndex = 6;
            label4.Text = "OPIS";
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
            label1.Location = new Point(323, 25);
            label1.Name = "label1";
            label1.Size = new Size(149, 33);
            label1.TabIndex = 0;
            label1.Text = "KATEGORIJE";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.OrangeRed;
            button3.Location = new Point(-5, 231);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(97, 31);
            button3.TabIndex = 6;
            button3.Text = "PROIZVODI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(-5, 164);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(96, 31);
            button2.TabIndex = 5;
            button2.Text = "KATEGORIJE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(-5, 103);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "TRGOVCI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(-5, 771);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 7;
            label7.Text = "ODJAVI SE";
            label7.Click += label7_Click;
            // 
            // FormaKategorije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 841);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormaKategorije";
            Text = "FormaKategorije";
            Load += FormaKategorije_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)katGDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView katGDV;
        private Button button7;
        private Button button6;
        private Button button4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox OpisKategorijeTb;
        private TextBox NazivKategorijeTb;
        private TextBox IdKategorijeTb;
        private Label label7;
    }
}