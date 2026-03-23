namespace WinFormsApp2
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
            lblOrtalama = new Label();
            txtVize = new TextBox();
            txtFinal = new TextBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Vize:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Final:";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(35, 111);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(74, 20);
            lblOrtalama.TabIndex = 2;
            lblOrtalama.Text = "Ortalama:";
            // 
            // txtVize
            // 
            txtVize.Location = new Point(126, 24);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(125, 27);
            txtVize.TabIndex = 3;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(126, 62);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(125, 27);
            txtFinal.TabIndex = 4;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(82, 180);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(94, 29);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 231);
            Controls.Add(btnHesapla);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(lblOrtalama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblOrtalama;
        private TextBox txtVize;
        private TextBox txtFinal;
        private Button btnHesapla;
    }
}
