using System;
using System.IO;

namespace OpenWriteFile
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.linksoben = new System.Windows.Forms.TextBox();
            this.linksunten = new System.Windows.Forms.TextBox();
            this.rechtsunten = new System.Windows.Forms.TextBox();
            this.rechtsoben = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bmw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zielOrdnerTextbox = new System.Windows.Forms.TextBox();
            this.quellOrdnerTextbox = new System.Windows.Forms.TextBox();
            this.quellOrdner = new System.Windows.Forms.Button();
            this.zielOrdner = new System.Windows.Forms.Button();
            this.honsel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStarten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open a file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.zielOrdner_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 287);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(887, 42);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // linksoben
            // 
            this.linksoben.Location = new System.Drawing.Point(532, 28);
            this.linksoben.Name = "linksoben";
            this.linksoben.Size = new System.Drawing.Size(100, 20);
            this.linksoben.TabIndex = 4;
            // 
            // linksunten
            // 
            this.linksunten.Location = new System.Drawing.Point(532, 81);
            this.linksunten.Name = "linksunten";
            this.linksunten.Size = new System.Drawing.Size(100, 20);
            this.linksunten.TabIndex = 5;
            // 
            // rechtsunten
            // 
            this.rechtsunten.Location = new System.Drawing.Point(636, 81);
            this.rechtsunten.Name = "rechtsunten";
            this.rechtsunten.Size = new System.Drawing.Size(100, 20);
            this.rechtsunten.TabIndex = 6;
            // 
            // rechtsoben
            // 
            this.rechtsoben.Location = new System.Drawing.Point(636, 28);
            this.rechtsoben.Name = "rechtsoben";
            this.rechtsoben.Size = new System.Drawing.Size(100, 20);
            this.rechtsoben.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rechtsoben";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Linksunten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Linksoben";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rechtsunten";
            // 
            // bmw
            // 
            this.bmw.Location = new System.Drawing.Point(754, 26);
            this.bmw.Name = "bmw";
            this.bmw.Size = new System.Drawing.Size(98, 23);
            this.bmw.TabIndex = 12;
            this.bmw.Text = "BMW_LOGO";
            this.bmw.UseVisualStyleBackColor = true;
            this.bmw.Click += new System.EventHandler(this.bmw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rechtsunten";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Linksunten";
            // 
            // zielOrdnerTextbox
            // 
            this.zielOrdnerTextbox.Location = new System.Drawing.Point(13, 155);
            this.zielOrdnerTextbox.Name = "zielOrdnerTextbox";
            this.zielOrdnerTextbox.Size = new System.Drawing.Size(338, 20);
            this.zielOrdnerTextbox.TabIndex = 14;
            // 
            // quellOrdnerTextbox
            // 
            this.quellOrdnerTextbox.Location = new System.Drawing.Point(13, 81);
            this.quellOrdnerTextbox.Name = "quellOrdnerTextbox";
            this.quellOrdnerTextbox.Size = new System.Drawing.Size(338, 20);
            this.quellOrdnerTextbox.TabIndex = 13;
            // 
            // quellOrdner
            // 
            this.quellOrdner.Location = new System.Drawing.Point(356, 81);
            this.quellOrdner.Name = "quellOrdner";
            this.quellOrdner.Size = new System.Drawing.Size(23, 20);
            this.quellOrdner.TabIndex = 17;
            this.quellOrdner.Text = "...";
            this.quellOrdner.UseVisualStyleBackColor = true;
            this.quellOrdner.Click += new System.EventHandler(this.quellordner_Click);
            // 
            // zielOrdner
            // 
            this.zielOrdner.Location = new System.Drawing.Point(355, 154);
            this.zielOrdner.Name = "zielOrdner";
            this.zielOrdner.Size = new System.Drawing.Size(24, 21);
            this.zielOrdner.TabIndex = 18;
            this.zielOrdner.Text = "...";
            this.zielOrdner.UseVisualStyleBackColor = true;
            this.zielOrdner.Click += new System.EventHandler(this.zielOrdner_Click);
            // 
            // honsel
            // 
            this.honsel.Location = new System.Drawing.Point(754, 79);
            this.honsel.Name = "honsel";
            this.honsel.Size = new System.Drawing.Size(98, 23);
            this.honsel.TabIndex = 19;
            this.honsel.Text = "HONSEL_LOGO";
            this.honsel.UseVisualStyleBackColor = true;
            this.honsel.Click += new System.EventHandler(this.honsel_Click);
            // 
            // btnStarten
            // 
            this.btnStarten.Location = new System.Drawing.Point(13, 210);
            this.btnStarten.Name = "btnStarten";
            this.btnStarten.Size = new System.Drawing.Size(75, 23);
            this.btnStarten.TabIndex = 20;
            this.btnStarten.Text = "Starten";
            this.btnStarten.UseVisualStyleBackColor = true;
            this.btnStarten.Click += new System.EventHandler(this.btnStarten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 493);
            this.Controls.Add(this.btnStarten);
            this.Controls.Add(this.honsel);
            this.Controls.Add(this.quellOrdner);
            this.Controls.Add(this.zielOrdner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zielOrdnerTextbox);
            this.Controls.Add(this.quellOrdnerTextbox);
            this.Controls.Add(this.bmw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rechtsoben);
            this.Controls.Add(this.rechtsunten);
            this.Controls.Add(this.linksunten);
            this.Controls.Add(this.linksoben);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ReadWrite File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox linksoben;
        private System.Windows.Forms.TextBox linksunten;
        private System.Windows.Forms.TextBox rechtsunten;
        private System.Windows.Forms.TextBox rechtsoben;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bmw;
        private System.Windows.Forms.TextBox quellOrdnerTextbox;
        private System.Windows.Forms.TextBox zielOrdnerTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button quellOrdner;
        private System.Windows.Forms.Button zielOrdner;
        private System.Windows.Forms.Button honsel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStarten;
    }
}

