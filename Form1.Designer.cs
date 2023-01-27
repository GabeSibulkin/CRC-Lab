
namespace CRC_Lab
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
            this.DataBox = new System.Windows.Forms.RichTextBox();
            this.GrabInputFiles = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.CRC_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Decimal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataBox
            // 
            this.DataBox.Enabled = false;
            this.DataBox.Location = new System.Drawing.Point(35, 212);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(352, 187);
            this.DataBox.TabIndex = 0;
            this.DataBox.Text = "";
            // 
            // GrabInputFiles
            // 
            this.GrabInputFiles.Location = new System.Drawing.Point(35, 77);
            this.GrabInputFiles.Name = "GrabInputFiles";
            this.GrabInputFiles.Size = new System.Drawing.Size(99, 38);
            this.GrabInputFiles.TabIndex = 1;
            this.GrabInputFiles.Text = "Go\'ne Git";
            this.GrabInputFiles.UseVisualStyleBackColor = true;
            this.GrabInputFiles.Click += new System.EventHandler(this.GrabInputFiles_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(178, 85);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(437, 22);
            this.PathBox.TabIndex = 2;
            // 
            // CRC_Button
            // 
            this.CRC_Button.Location = new System.Drawing.Point(35, 121);
            this.CRC_Button.Name = "CRC_Button";
            this.CRC_Button.Size = new System.Drawing.Size(99, 38);
            this.CRC_Button.TabIndex = 3;
            this.CRC_Button.Text = "Calc CRC";
            this.CRC_Button.UseVisualStyleBackColor = true;
            this.CRC_Button.Click += new System.EventHandler(this.CRC_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(548, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(548, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(548, 307);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 7;
            // 
            // Decimal
            // 
            this.Decimal.AutoSize = true;
            this.Decimal.Location = new System.Drawing.Point(469, 215);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(58, 17);
            this.Decimal.TabIndex = 8;
            this.Decimal.Text = "Decimal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Octal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Binary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CRC_Button);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.GrabInputFiles);
            this.Controls.Add(this.DataBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DataBox;
        private System.Windows.Forms.Button GrabInputFiles;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button CRC_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Decimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

