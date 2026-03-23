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
            lblVize = new Label();
            lblFinal = new Label();
            vizeTxt = new TextBox();
            finalTxt = new TextBox();
            lblSonuc = new Label();
            lblOrtalama = new Label();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // lblVize
            // 
            lblVize.AutoSize = true;
            lblVize.Location = new Point(26, 47);
            lblVize.Name = "lblVize";
            lblVize.Size = new Size(40, 20);
            lblVize.TabIndex = 0;
            lblVize.Text = "Vize:";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(26, 112);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(43, 20);
            lblFinal.TabIndex = 1;
            lblFinal.Text = "Final:";
            // 
            // vizeTxt
            // 
            vizeTxt.Location = new Point(72, 40);
            vizeTxt.Name = "vizeTxt";
            vizeTxt.Size = new Size(125, 27);
            vizeTxt.TabIndex = 2;
            // 
            // finalTxt
            // 
            finalTxt.Location = new Point(72, 105);
            finalTxt.Name = "finalTxt";
            finalTxt.Size = new Size(125, 27);
            finalTxt.TabIndex = 3;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(106, 150);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 4;
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(26, 150);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(74, 20);
            lblOrtalama.TabIndex = 5;
            lblOrtalama.Text = "Ortalama:";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(72, 192);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(125, 45);
            btnHesapla.TabIndex = 6;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 249);
            Controls.Add(btnHesapla);
            Controls.Add(lblOrtalama);
            Controls.Add(lblSonuc);
            Controls.Add(finalTxt);
            Controls.Add(vizeTxt);
            Controls.Add(lblFinal);
            Controls.Add(lblVize);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVize;
        private Label lblFinal;
        private TextBox vizeTxt;
        private TextBox finalTxt;
        private Label lblSonuc;
        private Label lblOrtalama;
        private Button btnHesapla;
    }
}
