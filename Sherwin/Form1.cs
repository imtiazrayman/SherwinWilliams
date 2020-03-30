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
        private int l = 0;

        private string[] numbertag = new string[36];
        private string[] paintname = new string[36];
        int uniquecode = 12345;
        int customerID = 1321 / 232;

        public void entry()
        {

        }
        public int customerId(int code)
        {
            customerID++;
            uniquecode = uniquecode + customerID;
            return uniquecode;
        }
        public Form1()
        {
            InitializeComponent();


            //AEAEAE // EBRAHIMI PLATINUM ..safe color is (9999999)
            //ffcc00 sandra gold 

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
                color1index = i;
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
              
                panel12.BackColor = Color.FromArgb(panel3.BackColor.R, panel3.BackColor.G, panel3.BackColor.B);
                label2.Text = label1.Text;
                label4.Text = panel3.BackColor.R.ToString() + "-" + panel3.BackColor.G.ToString() + "-" + panel3.BackColor.B.ToString();
                label3.Text = "USCC Sherwin-Williams color.";
                // label16.Visible = true;
                // textBox3.Visible = true;
                i = 0; 
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
         
            int mixRed, mixBlue, mixGreen;

            mixRed = colorMixer(panel1.BackColor.R, panel2.BackColor.R);
            mixGreen = colorMixer(panel1.BackColor.G, panel2.BackColor.G);
            mixBlue = colorMixer(panel1.BackColor.B, panel2.BackColor.B);
            panel3.BackColor = Color.FromArgb(mixRed, mixGreen, mixBlue);
            label1.Text = label13.Text.ToString() + " and " + label14.Text.ToString();
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
            if (color < 1534)
            {
                i++;
                return i;
            }
            return 0;
        }

        public int goback(int color)
        {
            if (color < 1534 && color > 0)
            {
                i--;
                return i;
            }
            else if (color > 1534)
            {
                return 0; 
            }
            return 1533;
        }








        public int colorMixer(int color1, int color2)
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





        private void button19_Click(object sender, EventArgs e)// end of panel 2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // panel12.BackColor = Color.FromArgb(panel1.BackColor.R, panel1.BackColor.G, panel1.BackColor.B);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel12.BackColor = Color.FromArgb(panel2.BackColor.R, panel2.BackColor.G, panel2.BackColor.B);
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            panel12.BackColor = Color.FromArgb(panel3.BackColor.R, panel3.BackColor.G, panel3.BackColor.B);
            label2.Text = label1.Text;
            label4.Text = panel3.BackColor.R.ToString() + "-" + panel3.BackColor.G.ToString() + "-" + panel3.BackColor.B.ToString();
            label3.Text = "USCC Sherwin-Williams color.";
            label16.Visible = true;
            textBox3.Visible = true;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel12.BackColor = Color.FromArgb(panel1.BackColor.R, panel1.BackColor.G, panel1.BackColor.B);
            label4.Text = panel1.BackColor.R.ToString() + "-" + panel1.BackColor.G.ToString() + "-" + panel1.BackColor.B.ToString();
            label2.Text = label13.Text.ToString();
            label3.Text = label10.Text.ToString();
            label16.Visible = false;
            textBox3.Visible = false;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            panel12.BackColor = Color.FromArgb(panel2.BackColor.R, panel2.BackColor.G, panel2.BackColor.B);
            label4.Text = panel2.BackColor.R.ToString() + "-" + panel2.BackColor.G.ToString() + "-" + panel2.BackColor.B.ToString();
            label2.Text = label14.Text.ToString();
            label3.Text = label11.Text.ToString();
            label16.Visible = false;
            textBox3.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel14.BackColor = Color.FromArgb(238, 238, 238);
            label19.Text = "";
            label17.Text = "";

        }

        private void button39_Click(object sender, EventArgs e) // this is the forward arrow for the first panel. 
        {
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
                color1index = i;
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
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
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
             //   button1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
              //  panel1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
              
                color1index = i;
                i = nextcolor(i);

            //    button2.BackColor = Color.FromArgb(red[i], green[i], blue[i]);// row 1 panel 1
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

            //    button3.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

              //  button4.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

               // button5.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

             //   button6.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

              //  button7.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);//row 2 panel 1

              //  button8.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

              //  button9.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

             //   button10.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

             //   button11.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

              //  button12.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

               // button13.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);//row 4 panel 1

              //  button14.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

               // button15.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

             //   button16.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

              //  button17.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                //button18.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i);

                button19.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                j++;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                i = nextcolor(i); // row 1 panel 2

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
        
        private void button40_Click(object sender, EventArgs e)
        {
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

            
            if (i < 1534 && i > 18) 
            {
                i--;
                button1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                panel1.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();
                label10.Text = colorTag[i].ToString();
                label13.Text = names[i];
                color1index = i;
                i = goback(i);

                button2.BackColor = Color.FromArgb(red[i], green[i], blue[i]);// row 1 panel 1
                /*j--;
                paintname[j] = names[i];
                numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button3.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button4.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
    paintname[j] = names[i];
    numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button5.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button6.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button7.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
    paintname[j] = names[i];
    numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);//row 2 panel 1

                button8.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
  paintname[j] = names[i];
  numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button9.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button10.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button11.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
     paintname[j] = names[i];
     numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button12.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
     paintname[j] = names[i];
     numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button13.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
   paintname[j] = names[i];
   numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);//row 4 panel 1

                button14.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button15.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
   paintname[j] = names[i];
   numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button16.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
  paintname[j] = names[i];
  numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button17.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
   paintname[j] = names[i];
   numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);

                button18.BackColor = Color.FromArgb(red[i], green[i], blue[i]);
                /*j--;
 paintname[j] = names[i];
 numbertag[j] = colorTag[i].ToString();*/
                i = goback(i);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString();
            int code = customerId(uniquecode);

            if (label16.Visible == false && textBox3.Visible == false) // if the USCC COLOR not selected but regular Sherwin Williams Color.
            {
                DialogResult msg = MessageBox.Show("Hello, " + name + ", you have selected " + label2.Text.ToString() + "\nWhich is RGB color " + label4.Text.ToString() + 
                    "\nWould you like to proceed?", "Sherwin Williams " + " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (msg == DialogResult.OK)
                {
                    label17.Text = "Purchase Information\nColor Purchased :" + label2.Text.ToString() + "\nRGB color : " + label4.Text.ToString() + "\nColor Code : " + label3.Text.ToString();
                    label19.Visible = true;
                    panel14.BackColor = panel12.BackColor;
                    label17.Visible = true;
                }
                else if (msg == DialogResult.Cancel)
                {
                    label17.Text = "Cancelled Transaction";
                }
            }
            else{
                DialogResult msg = MessageBox.Show("Hello " + name + ", you have selected a color that is a combination of " + label2.Text.ToString() + 
                    "\nYour Unique color name is (" + textBox3.Text.ToString() + ")\nWhich is RGB color " + label4.Text.ToString() + 
                    "\nYour Unique Code is #" + code.ToString() + "\nWould you like to proceed?", "Sherwin Williams Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (msg == DialogResult.Yes)
                {
                    label17.Text = "Purchase Information\nColor Purchased :" + label2.Text.ToString() + "\nRGB color : " + label4.Text.ToString() + "\nUnique Color Code : " + code.ToString();
                    label19.Visible = true;
                    panel14.BackColor = panel12.BackColor;
                    label17.Visible = true;
                }
                else if (msg == DialogResult.No)
                {
                    label17.Text = "Cancelled Transaction";
                }
            }


        }
    }



}
