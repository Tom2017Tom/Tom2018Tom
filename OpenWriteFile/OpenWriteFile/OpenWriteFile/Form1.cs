/* Made by TheDarkJoker94. 
*  Check http://thedarkjoker094.blogspot.com/ for more C# Tutorials 
*  and also SUBSCRIBE to my Youtube Channel http://www.youtube.com/user/TheDarkJoker094 
*  Thanks! */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace OpenWriteFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private string EinzelDateiBearbeitung(string TextBoxInhalt)
        {

           
            string tracePattern1;
            Regex traceRegex;
            Match m;
            String zahl;
            int zwischen_x;
            int zwischen_y;
            string traceBoundingBox;
            Regex traceRegexBoundingBox;
            Match matchBoundingBox;
            String[] subBoundingBoxes;
            int rahmen_x;
            int rahmen_y;

            //double startKoordinat_x=270;
            //double startKoordinat_y=272;
            //double endKoordinat_x=302;
            //double endKoordinat_y=290;
            double scale;
            scale = 3371.0 / 1189.0;

            double startKoordinat_x;//- (420.0-270.0);
            double startKoordinat_y;//- (297.0 - 272.0);
            double endKoordinat_x;//- (420.0 - 302.0);
            double endKoordinat_y;//- (297.0 - 290.0);

            double startScaledKoordinat_x;
            double startScaledKoordinat_y;
            double endScaledKoordinat_x;
            double endScaledKoordinat_y;

            int startIndex;
            int endIndex;
            string atZeichen;
            Boolean gefunden;
            string deletedText;

            tracePattern1 = @"\n(\d\d\d\d?\.?\d?\d?)\s(\d\d\d\d?\.?\d?\d?)\s(mo)\r|\n@\r";
            traceRegex = new Regex(tracePattern1);
            m = traceRegex.Match(TextBoxInhalt);
            traceBoundingBox = @"(%%BoundingBox:)\s(.*)\r";
            traceRegexBoundingBox = new Regex(traceBoundingBox);
            matchBoundingBox = traceRegexBoundingBox.Match(TextBoxInhalt);
            subBoundingBoxes = matchBoundingBox.Groups[0].Value.Split(' ');
            rahmen_x = Convert.ToInt32(subBoundingBoxes[3]);
            rahmen_y = Convert.ToInt32(subBoundingBoxes[4]);

            //double startKoordinat_x=270;
            //double startKoordinat_y=272;
            //double endKoordinat_x=302;
            //double endKoordinat_y=290;

            startKoordinat_x = rahmen_x / scale - Convert.ToDouble(this.linksoben.Text);//- (420.0-270.0);
            startKoordinat_y = rahmen_y / scale - Convert.ToDouble(this.linksunten.Text);//- (297.0 - 272.0);
            endKoordinat_x = rahmen_x / scale - Convert.ToDouble(this.rechtsoben.Text);//- (420.0 - 302.0);
            endKoordinat_y = rahmen_y / scale - Convert.ToDouble(this.rechtsunten.Text);//- (297.0 - 290.0);

            startScaledKoordinat_x = startKoordinat_x * scale;
            startScaledKoordinat_y = startKoordinat_y * scale;
            endScaledKoordinat_x = endKoordinat_x * scale;
            endScaledKoordinat_y = endKoordinat_y * scale;

            startIndex = 0;
            atZeichen = "\n@\r";
            gefunden = false;
            deletedText = "";

            while (m.Success)
            {
                //if (m.Index > 299400)
                //    atZeichen = "\n@\r";
                if (m.Groups[0].Value.Equals(atZeichen))
                {
                    #region textBehandlung
                    endIndex = m.Index + atZeichen.Length - 1;
                    if (gefunden)
                    {
                        startIndex = endIndex + 1;
                        deletedText = deletedText + AbschnittPaste(startIndex, endIndex);
                        gefunden = false;
                    }
                    else
                    {
                        deletedText = deletedText + AbschnittPaste(startIndex, endIndex);
                        startIndex = endIndex + 1;

                    }
                    #endregion
                    //Console.WriteLine("@");
                    //Console.WriteLine(m.Index);
                }
                else
                {
                    zahl = m.Groups[1].Value;
                    String[] substrings = zahl.Split('.');
                    zwischen_x = Convert.ToInt32(substrings[0]);
                    zahl = m.Groups[2].Value;
                    substrings = zahl.Split('.');
                    zwischen_y = Convert.ToInt32(substrings[0]);
                    //if ((zwischen_y==781) && (zwischen_x == 739))
                    //    zwischen_y = zwischen_y;

                    if (zwischen_x <= endScaledKoordinat_x && zwischen_x >= startScaledKoordinat_x && zwischen_y <= endScaledKoordinat_y && zwischen_y >= startScaledKoordinat_y)
                    {
                        gefunden = true;
                        //Console.WriteLine(m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value);

                    }
                    else
                    {
                        #region textBehandlung
                        endIndex = m.Index + m.Length - 1;
                        if (gefunden)
                        {
                            startIndex = endIndex + 1;
                            deletedText = deletedText + AbschnittPaste(startIndex, endIndex);
                            gefunden = false;
                        }
                        else
                        {
                            deletedText = deletedText + AbschnittPaste(startIndex, endIndex);
                            startIndex = endIndex + 1;

                        }
                        #endregion
                    }

                }
                m = m.NextMatch();
            }
            deletedText = deletedText + AbschnittPaste(startIndex, TextBoxInhalt.Length - 1);
            return deletedText;
        }


        private string AbschnittPaste(int startIndex,  int endIndex)
        {
            if (startIndex > endIndex)
                return "";
            int length;
            length = endIndex - startIndex + 1;
            return textBox1.Text.Substring(startIndex, length);
        }

        private void zielOrdner_Click(object sender, EventArgs e)
        {
            // Show the openFileDialog.When Ok is pressed, read the file and copy its content into the textBox1.

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                quellOrdnerTextbox.Text = folderBrowserDialog1.SelectedPath;
                //zielOrdnerTextbox.Text = File.ReadAllText(label1.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bmw_Click(object sender, EventArgs e)
        {
            this.linksoben.Text =  (420.0 - 265.0).ToString();
            this.linksunten.Text = (297.0 - 267.0).ToString();
            this.rechtsoben.Text = (420.0 - 302.0 - 40).ToString();
            this.rechtsunten.Text = (297.0 - 290.0).ToString();
        }

        private void honsel_Click(object sender, EventArgs e)
        {
            this.linksoben.Text = (420.0 - 265.0).ToString();
            this.linksunten.Text = (297.0 - 267.0).ToString();
            this.rechtsoben.Text = (420.0 - 302.0 - 40).ToString();
            this.rechtsunten.Text = (297.0 - 290.0).ToString();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void quellordner_Click(object sender, EventArgs e)
        {
            // Show the openFileDialog.When Ok is pressed, read the file and copy its content into the textBox1.

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                quellOrdnerTextbox.Text = folderBrowserDialog1.SelectedPath;
                //zielOrdnerTextbox.Text = File.ReadAllText(label1.Text);
            }
        }
        private void btnStarten_Click(object sender, EventArgs e)
        {
            //// Show the saveFileDialog. When Ok is pressed, save the content of the textBox1 into the chosen file.
            //if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);   
            //}
            DirectoryInfo di = new DirectoryInfo(this.quellOrdnerTextbox.Text);
            string komplettQuellenPfad;
            string komplettZielPfad;

            foreach (var fi in di.GetFiles())
            {
                komplettQuellenPfad = this.quellOrdnerTextbox.Text + "\\" + fi.Name;
                komplettZielPfad = zielOrdnerTextbox.Text + "\\" + fi.Name;
                textBox1.Text = File.ReadAllText(komplettQuellenPfad);
                if (textBox1.Text.Length < 900000)
                    File.WriteAllText(komplettZielPfad, EinzelDateiBearbeitung(textBox1.Text));
            }
        }
    }
}
