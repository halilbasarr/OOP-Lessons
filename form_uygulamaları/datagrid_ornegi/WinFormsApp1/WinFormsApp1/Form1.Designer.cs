namespace WinFormsApp1
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
            tcNo = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tc = new DataGridViewTextBoxColumn();
            Ad = new DataGridViewTextBoxColumn();
            Soyad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tcNo
            // 
            tcNo.AutoSize = true;
            tcNo.Location = new Point(12, 41);
            tcNo.Name = "tcNo";
            tcNo.Size = new Size(147, 20);
            tcNo.TabIndex = 0;
            tcNo.Text = "T.C. Kimlik Numarası:";
            tcNo.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(56, 175);
            button1.Name = "button1";
            button1.Size = new Size(211, 65);
            button1.TabIndex = 6;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tc, Ad, Soyad });
            dataGridView1.Location = new Point(325, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(618, 202);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tc
            // 
            tc.DataPropertyName = "T.C. Kimlik Numarası";
            tc.HeaderText = "T.C. Kimlik Numarası";
            tc.MinimumWidth = 6;
            tc.Name = "tc";
            tc.Width = 125;
            // 
            // Ad
            // 
            Ad.DataPropertyName = "Ad";
            Ad.HeaderText = "Ad";
            Ad.MinimumWidth = 6;
            Ad.Name = "Ad";
            Ad.Width = 125;
            // 
            // Soyad
            // 
            Soyad.DataPropertyName = "Soyad";
            Soyad.HeaderText = "Soyad";
            Soyad.MinimumWidth = 6;
            Soyad.Name = "Soyad";
            Soyad.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 331);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tcNo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tcNo;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tc;
        private DataGridViewTextBoxColumn Ad;
        private DataGridViewTextBoxColumn Soyad;
    }
}
