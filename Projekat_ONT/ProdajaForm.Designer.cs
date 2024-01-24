namespace Projekat_ONT
{
    partial class ProdajaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdajaForm));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            dgvrac = new DataGridView();
            dgv = new DataGridView();
            trgovacime = new Label();
            ukupnLB = new Label();
            label6 = new Label();
            button1 = new Button();
            datelabel = new Label();
            CijenaTB = new TextBox();
            KolicinaTB = new TextBox();
            ArtikalTB = new TextBox();
            BrojracTB = new TextBox();
            button6 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label7 = new Label();
            IDpro = new DataGridViewTextBoxColumn();
            Artikal = new DataGridViewTextBoxColumn();
            Cijena = new DataGridViewTextBoxColumn();
            Količina = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvrac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dgvrac);
            panel1.Controls.Add(dgv);
            panel1.Controls.Add(trgovacime);
            panel1.Controls.Add(ukupnLB);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(datelabel);
            panel1.Controls.Add(CijenaTB);
            panel1.Controls.Add(KolicinaTB);
            panel1.Controls.Add(ArtikalTB);
            panel1.Controls.Add(BrojracTB);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(150, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 791);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.Location = new Point(351, 65);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 288);
            dataGridView1.TabIndex = 33;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Artikal";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cijena";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Količina";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Ukupno";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(884, 477);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(125, 66);
            button2.TabIndex = 32;
            button2.Text = "Spremi račun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvrac
            // 
            dgvrac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrac.Location = new Point(371, 477);
            dgvrac.Margin = new Padding(3, 4, 3, 4);
            dgvrac.Name = "dgvrac";
            dgvrac.RowHeadersWidth = 51;
            dgvrac.RowTemplate.Height = 25;
            dgvrac.Size = new Size(493, 240);
            dgvrac.TabIndex = 31;
            // 
            // dgv
            // 
            dgv.AllowUserToOrderColumns = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 422);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(328, 295);
            dgv.TabIndex = 30;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // trgovacime
            // 
            trgovacime.AutoSize = true;
            trgovacime.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            trgovacime.ForeColor = Color.White;
            trgovacime.Location = new Point(18, 17);
            trgovacime.Name = "trgovacime";
            trgovacime.Size = new Size(102, 33);
            trgovacime.TabIndex = 29;
            trgovacime.Text = "Trgovac";
            // 
            // ukupnLB
            // 
            ukupnLB.AutoSize = true;
            ukupnLB.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ukupnLB.ForeColor = Color.White;
            ukupnLB.Location = new Point(699, 378);
            ukupnLB.Name = "ukupnLB";
            ukupnLB.Size = new Size(54, 33);
            ukupnLB.TabIndex = 26;
            ukupnLB.Text = "KM";
            ukupnLB.Click += ukupnLB_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(351, 381);
            label6.Name = "label6";
            label6.Size = new Size(110, 33);
            label6.TabIndex = 25;
            label6.Text = "Ukupno:";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(139, 378);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(169, 36);
            button1.TabIndex = 24;
            button1.Text = "Dodaj proizvod";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // datelabel
            // 
            datelabel.AutoSize = true;
            datelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            datelabel.ForeColor = Color.White;
            datelabel.Location = new Point(777, 17);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(57, 20);
            datelabel.TabIndex = 22;
            datelabel.Text = "Datum";
            // 
            // CijenaTB
            // 
            CijenaTB.Location = new Point(139, 208);
            CijenaTB.Margin = new Padding(3, 4, 3, 4);
            CijenaTB.Name = "CijenaTB";
            CijenaTB.Size = new Size(169, 27);
            CijenaTB.TabIndex = 20;
            CijenaTB.TextChanged += CijenaProizvodaTB_TextChanged;
            // 
            // KolicinaTB
            // 
            KolicinaTB.Location = new Point(139, 281);
            KolicinaTB.Margin = new Padding(3, 4, 3, 4);
            KolicinaTB.Name = "KolicinaTB";
            KolicinaTB.Size = new Size(169, 27);
            KolicinaTB.TabIndex = 19;
            // 
            // ArtikalTB
            // 
            ArtikalTB.Location = new Point(139, 135);
            ArtikalTB.Margin = new Padding(3, 4, 3, 4);
            ArtikalTB.Name = "ArtikalTB";
            ArtikalTB.Size = new Size(169, 27);
            ArtikalTB.TabIndex = 18;
            // 
            // BrojracTB
            // 
            BrojracTB.Location = new Point(139, 65);
            BrojracTB.Margin = new Padding(3, 4, 3, 4);
            BrojracTB.Name = "BrojracTB";
            BrojracTB.Size = new Size(169, 27);
            BrojracTB.TabIndex = 17;
            BrojracTB.TextChanged += BrojracTB_TextChanged;
            // 
            // button6
            // 
            button6.BackColor = Color.Snow;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.OrangeRed;
            button6.Location = new Point(227, 725);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(526, 61);
            button6.TabIndex = 10;
            button6.Text = "PRINTAJ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 208);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 8;
            label5.Text = "Cijena";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 277);
            label4.Name = "label4";
            label4.Size = new Size(92, 29);
            label4.TabIndex = 6;
            label4.Text = "Količina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 131);
            label3.Name = "label3";
            label3.Size = new Size(81, 29);
            label3.TabIndex = 4;
            label3.Text = "Artikal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 1;
            label2.Text = "Broj računa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(351, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 0;
            label1.Text = "PRODAJA";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(14, 776);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 2;
            label7.Text = "ODJAVI SE";
            label7.Click += label7_Click;
            // 
            // IDpro
            // 
            IDpro.HeaderText = "ID";
            IDpro.MinimumWidth = 6;
            IDpro.Name = "IDpro";
            IDpro.Width = 125;
            // 
            // Artikal
            // 
            Artikal.HeaderText = "Artikal";
            Artikal.MinimumWidth = 6;
            Artikal.Name = "Artikal";
            Artikal.Width = 125;
            // 
            // Cijena
            // 
            Cijena.HeaderText = "Cijena";
            Cijena.MinimumWidth = 6;
            Cijena.Name = "Cijena";
            Cijena.Width = 125;
            // 
            // Količina
            // 
            Količina.HeaderText = "Količina";
            Količina.MinimumWidth = 6;
            Količina.Name = "Količina";
            Količina.Width = 125;
            // 
            // ProdajaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 1057);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProdajaForm";
            Text = "ProdajaForm";
            Load += ProdajaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvrac).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox CijenaTB;
        private TextBox KolicinaTB;
        private TextBox ArtikalTB;
        private TextBox BrojracTB;
        private Button button6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label datelabel;
        private Button button1;
        private Label ukupnLB;
        private Label label6;
        private Label trgovacime;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label7;
        private DataGridView dgv;
        private DataGridView dgvrac;
        private Button button2;
        private DataGridViewTextBoxColumn IDpro;
        private DataGridViewTextBoxColumn Artikal;
        private DataGridViewTextBoxColumn Cijena;
        private DataGridViewTextBoxColumn Količina;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}