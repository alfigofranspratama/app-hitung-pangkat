namespace hitungPangkatApp
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
            txtA = new TextBox();
            txtB = new TextBox();
            label2 = new Label();
            txtC = new TextBox();
            label3 = new Label();
            txtD = new TextBox();
            label4 = new Label();
            btnApply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 0;
            label1.Text = "A";
            // 
            // txtA
            // 
            txtA.Location = new Point(38, 14);
            txtA.Name = "txtA";
            txtA.Size = new Size(181, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(38, 43);
            txtB.Name = "txtB";
            txtB.Size = new Size(181, 23);
            txtB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 41);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 2;
            label2.Text = "B";
            // 
            // txtC
            // 
            txtC.Location = new Point(38, 72);
            txtC.Name = "txtC";
            txtC.Size = new Size(181, 23);
            txtC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 70);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 4;
            label3.Text = "C";
            // 
            // txtD
            // 
            txtD.Location = new Point(38, 101);
            txtD.Name = "txtD";
            txtD.ReadOnly = true;
            txtD.Size = new Size(259, 23);
            txtD.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 99);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 6;
            label4.Text = "D";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(225, 12);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(72, 83);
            btnApply.TabIndex = 8;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 137);
            Controls.Add(btnApply);
            Controls.Add(txtD);
            Controls.Add(label4);
            Controls.Add(txtC);
            Controls.Add(label3);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "App Hitung Pangkat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private TextBox txtB;
        private Label label2;
        private TextBox txtC;
        private Label label3;
        private TextBox txtD;
        private Label label4;
        private Button btnApply;
    }
}