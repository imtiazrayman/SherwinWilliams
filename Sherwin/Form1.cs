using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sherwin
{
    public partial class Form1 : Form
    {
        private int i = 0;
        bool button1clicked = false;
        bool button2clicked = false;
        bool button3clicked = false;
        bool button4clicked = false;
        bool button5clicked = false;
        bool button6clicked = false;
        bool button7clicked = false;
        bool button8clicked = false;
        bool button9clicked = false;
        bool button10clicked = false;
        bool button11clicked = false;
        bool button12clicked = false;
        bool button13clicked = false;
        bool button14clicked = false;
        bool button15clicked = false;
        bool button16clicked = false;
        bool button17clicked = false;
        bool button18clicked = false;
        bool button19clicked = false;
        bool button20clicked = false;
        bool button21clicked = false;
        bool button22clicked = false;
        bool button23clicked = false;
        bool button24clicked = false;
        bool button25clicked = false;
        bool button26clicked = false;
        bool button27clicked = false;
        bool button28clicked = false;
        bool button29clicked = false;
        bool button30clicked = false;
        bool button31clicked = false;
        bool button32clicked = false;
        bool button33clicked = false;
        bool button34clicked = false;
        bool button35clicked = false;
        bool button36clicked = false;

        private string[] numbertag = new string[36];
        private string [] paintname = new string [36];

        public void entry()
        {
           
        }
        public Form1()
        {
            InitializeComponent();
            int[] red = colorExtractor("sherwinred.txt");
            int[] green = colorExtractor("sherwingreen.txt");
            int[] blue = colorExtractor("sherwinblue.txt");
            int[] colorTag = colorExtractor("sherwintag.txt");
            string[] names = nameExtractor("sherwinname.txt");

            // 1534 is the magic number 

            int color1index = 0;
            int color2index = 0;
            int mixRed = 0;
            int mixBlue = 0;
            int mixGreen = 0;
            int j = 0;

            if (i < 1534)
            {
                button1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                panel1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                label10.Text = colorTag[i].ToString();
                label13.Text = names[i];
                i = nextcolor(i);

                button2.BackColor = Color.FromArgb(red[i], green[i], blue[i]);// row 1 panel 1
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button3.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button4.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button5.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button6.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button7.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);//row 2 panel 1

                button8.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button9.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button10.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button11.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button12.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button13.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);//row 4 panel 1

                button14.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button15.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button16.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button17.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button18.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button19.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                panel2.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                label11.Text = colorTag[i].ToString();
                label14.Text = names[i];
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                color2index = i;

                mixRed = colorMixer(red[color1index], red[color2index]);
                // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 
                mixBlue = colorMixer(blue[color1index], blue[color2index]);
                // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 
                mixGreen = colorMixer(green[color1index], green[color2index]);
                // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 

                // this will take the information and output it into the screen.. 
                label1.Text = names[color1index] + " and " + names[color2index];
                panel3.BackColor = Color.FromArgb(mixRed, mixGreen, mixBlue);
                i = nextcolor(i);

                button20.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i); // row 1 panel 2

                button21.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button22.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button23.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button24.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button25.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i); //row 3 panel 2

                button26.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button27.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button28.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button29.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button30.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button31.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);  //row 4 panel 2

                button32.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button33.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button34.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button35.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button36.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int[] colorExtractor(string filename)
        {
            string fileContent = File.ReadAllText(filename);

            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] integers = new int[integerStrings.Length];

            for (int n = 0; n < integerStrings.Length; n++)
                integers[n] = int.Parse(integerStrings[n]);

            return integers;
        }

        private void btnrandomcolor_Click(object sender, EventArgs e)
        {
           /*int panel1red = panel1.BackColor.R;
           int panel1green = panel1.BackColor.G;
           int panel1blue = panel1.BackColor.B;
           int mixRed, mixBlue, mixGreen;

           int panel2red = panel1.BackColor.R;
           int panel2green = panel1.BackColor.G;
           int panel2blue = panel1.BackColor.B;

           mixRed = colorMixer(panel1red, panel2red);
            // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 
           mixBlue = colorMixer(panel1blue, panel2blue);
            // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 
           mixGreen = colorMixer(panel1green, panel2green);
            // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 

            // this will take the information and output it into the screen..
            
            label1.Text = label13.Text.ToString() + " and " + label14.Text.ToString();
            panel3.BackColor = Color.FromArgb(mixRed, mixGreen, mixBlue);*/




             int[] red = colorExtractor("sherwinred.txt");
             int[] green = colorExtractor("sherwingreen.txt");
             int[] blue = colorExtractor("sherwinblue.txt");
             int[] colorTag = colorExtractor("sherwintag.txt");
             string[] names = nameExtractor("sherwinname.txt");

             // 1534 is the magic number 

             int color1index = 0;
             int color2index = 0;
             int mixRed = 0;
             int mixBlue = 0;
             int mixGreen = 0;
             int j = 0;

             if (i < 1534)
             {
                 button1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 panel1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 label10.Text = colorTag[i].ToString();
                 label13.Text = names[i];
                 i = nextcolor(i);

                 button2.BackColor = Color.FromArgb(red[i], green[i], blue[i]);// row 1 panel 1
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button3.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button4.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button5.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button6.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button7.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);//row 2 panel 1

                 button8.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button9.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button10.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button11.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button12.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button13.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);//row 4 panel 1

                 button14.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button15.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button16.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button17.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button18.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button19.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 panel2.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 label11.Text = colorTag[i].ToString();
                 label14.Text = names[i];
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 color2index = i;

                 mixRed = colorMixer(red[color1index], red[color2index]);
                 // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 
                 mixBlue = colorMixer(blue[color1index], blue[color2index]);
                 // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 
                 mixGreen = colorMixer(green[color1index], green[color2index]);
                 // this will mix the two red colors, and then it will take the ratio and implement it into a single red value. 

                 // this will take the information and output it into the screen.. 
                 label1.Text = names[color1index] + " and " + names[color2index];
                 panel3.BackColor = Color.FromArgb(mixRed, mixGreen, mixBlue);
                 i = nextcolor(i);

                 button20.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i); // row 1 panel 2

                 button21.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button22.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button23.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button24.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button25.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);//row 3 panel 2

                 button26.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button27.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button28.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button29.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button30.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button31.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);//row 4 panel 2

                 button32.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button33.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button34.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button35.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);

                 button36.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                 j++;
                 paintname[j] = names[i];
                 numbertag[j] = colorTag[i].ToString();
                 i = nextcolor(i);
             }
        }

        public string[] nameExtractor(string filename)
        {
            string fileContent = File.ReadAllText(filename);
            string[] integerStrings = fileContent.Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] integers = new string[integerStrings.Length];

            for (int n = 0; n < integerStrings.Length; n++)
                integers[n] = integerStrings[n];
            return integers;
        }

        private void label13_Click(object sender, EventArgs e)
        {
               
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button5.BackColor.R, button5.BackColor.G, button5.BackColor.B);
            int i = 4;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        public void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public int nextcolor(int color)
        {
            if(color < 1534)
            {
                i++;
                return i;
            }
            return 0;
        }

        public int colorMixer(int color1 , int color2)
        {
            int colorMixSum = (color1 + color2);
            int colorMixAvg = colorMixSum / 2;
            return colorMixAvg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button1.BackColor.R, button1.BackColor.G, button1.BackColor.B);
            int i = 0;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        public int Panel1Red(int red)
        {
            return red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button2.BackColor.R, button2.BackColor.G, button2.BackColor.B);
            int i = 1;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button3.BackColor.R, button3.BackColor.G, button3.BackColor.B);
            int i = 2;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button4.BackColor.R, button4.BackColor.G, button4.BackColor.B);
            int i = 3;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button6.BackColor.R, button6.BackColor.G, button6.BackColor.B);
            int i = 5;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button7.BackColor.R, button7.BackColor.G, button7.BackColor.B);
            int i = 6;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button8.BackColor.R, button8.BackColor.G, button8.BackColor.B);
            int i = 7;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button9.BackColor.R, button9.BackColor.G, button9.BackColor.B);
            int i = 8;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button10.BackColor.R, button10.BackColor.G, button10.BackColor.B);
            int i = 9;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button11.BackColor.R, button11.BackColor.G, button11.BackColor.B);
            int i = 10;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button12.BackColor.R, button12.BackColor.G, button12.BackColor.B);
            int i = 11;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button13.BackColor.R, button13.BackColor.G, button13.BackColor.B);
            int i = 12;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button14.BackColor.R, button14.BackColor.G, button14.BackColor.B);
            int i = 13;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button15.BackColor.R, button15.BackColor.G, button15.BackColor.B);
            int i = 14;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button16.BackColor.R, button16.BackColor.G, button16.BackColor.B);
            int i = 15;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button17.BackColor.R, button17.BackColor.G, button17.BackColor.B);
            int i = 16;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(button18.BackColor.R, button18.BackColor.G, button18.BackColor.B);
            int i = 17;
            label10.Text = numbertag[i];
            label13.Text = paintname[i];
            // label11.Text = 
        }





        private void button19_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button19.BackColor.R, button19.BackColor.G, button19.BackColor.B);
            int i = 18;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button20.BackColor.R, button20.BackColor.G, button20.BackColor.B);
            int i = 19;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button21.BackColor.R, button21.BackColor.G, button21.BackColor.B);
            int i = 20;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button22.BackColor.R, button22.BackColor.G, button22.BackColor.B);
            int i = 21;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button23.BackColor.R, button23.BackColor.G, button23.BackColor.B);
            int i = 22;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button24.BackColor.R, button24.BackColor.G, button24.BackColor.B);
            int i = 23;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button25.BackColor.R, button25.BackColor.G, button25.BackColor.B);
            int i = 24;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button26.BackColor.R, button26.BackColor.G, button26.BackColor.B);
            int i = 25;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button27.BackColor.R, button27.BackColor.G, button27.BackColor.B);
            int i = 26;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button28.BackColor.R, button28.BackColor.G, button28.BackColor.B);
            int i = 27;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button29.BackColor.R, button29.BackColor.G, button29.BackColor.B);
            int i = 28;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button30.BackColor.R, button30.BackColor.G, button30.BackColor.B);
            int i = 29;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button31.BackColor.R, button31.BackColor.G, button31.BackColor.B);
            int i = 30;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button32.BackColor.R, button32.BackColor.G, button32.BackColor.B);
            int i = 31;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button33.BackColor.R, button33.BackColor.G, button33.BackColor.B);
            int i = 32;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button34.BackColor.R, button34.BackColor.G, button34.BackColor.B);
            int i = 33;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button35.BackColor.R, button35.BackColor.G, button35.BackColor.B);
            int i = 34;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(button36.BackColor.R, button36.BackColor.G, button36.BackColor.B);
            int i = 35;
            label11.Text = numbertag[i];
            label14.Text = paintname[i];
        }
    }



}
