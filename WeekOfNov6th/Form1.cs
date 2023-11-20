using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Security;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //this converts temeratures
        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (rdoTempConverter1.Checked == true)
            {

                var celc = Convert.ToDouble (txtInput1.Text);
                rtbOutput.Text += celc * 9/5 + 32;
            }
            else if(rdoTempConverter2.Checked == true)
            {
                var far = Convert.ToDouble(txtInput1.Text);
                rtbOutput.Text += (far - 32) * 5 / 9;
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            var money = Convert.ToDouble(txtInput1.Text);
            //dollar to yen
            if (cmbMoneyConverter.SelectedIndex == 0)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 149.74} Yen";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 149.74} Yen";
                }
            }
            //yen to dollar
            if (cmbMoneyConverter.SelectedIndex == 1)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 0.0067} Dollars";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 0.0067} Dollars";
                }
            }
            //dollar to ruble
            if (cmbMoneyConverter.SelectedIndex == 2)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 93.02} Rubles";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 93.02} Rubles";
                }
            }
            //ruble to dollar
            if (cmbMoneyConverter.SelectedIndex == 3)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 0.011} Dollars";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 0.011} Dollars";
                }
            }
            //dollar to won
            if (cmbMoneyConverter.SelectedIndex == 4)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 1297.20} Won";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 1297.20} Won";
                }
            }
            //won to dollar
            if (cmbMoneyConverter.SelectedIndex == 5)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 0.00077} Dollars";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 0.00077} Dollars";
                }
            }
            //dollar to euro
            if (cmbMoneyConverter.SelectedIndex == 6)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 0.93} Euros";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 0.93} Euros";
                }
            }
            //euro to dollar
            if (cmbMoneyConverter.SelectedIndex == 7)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 1.07} Dollars";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 1.07} Dollars";
                }
            }
            //dollar to peso
            if (cmbMoneyConverter.SelectedIndex == 8)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 17.57} Pesos";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 17.57} Pesos";
                }
            }
            //peso to dollar
            if (cmbMoneyConverter.SelectedIndex == 9)
            {
                if (rtbOutput.Text == "")
                {
                    rtbOutput.Text += $"{money * 0.057} Dollars";
                }
                else
                {
                    rtbOutput.Text += $" \n{money * 0.057} Dollars";
                }
            }
        }
        //converts mi and km
        private void btnBigDist_Click(object sender, EventArgs e)
        {
            var distOne = Convert.ToDouble(txtInput1.Text);
            if (rtbOutput.Text != "")
            {
                rtbOutput.Text += "\n";
            }
            if (chkMileToKilo.Checked == true)
            {
                rtbOutput.Text += $"{distOne} Miles is{distOne * 1.609344} Kilometers";
            }
            if (chkKiloToMiles.Checked == true)
            {
                rtbOutput.Text += $"{distOne} Kilometers is {distOne * 0.62137119} Miles";
            }
        }
        //converts m and in
        private void btnSmallDist_Click(object sender, EventArgs e)
        {
            var distTwo = Convert.ToDouble(txtInput2.Text);
            if (rtbOutput.Text != "")
            {
                rtbOutput.Text += "\n";
            }
            if (chkMileToKilo.Checked == true)
            {
                rtbOutput.Text += $"{distTwo} Meters is{distTwo * 39.3700787} Inches";
            }
            if (chkKiloToMiles.Checked == true)
            {
                rtbOutput.Text += $"{distTwo} Inches is {distTwo * 0.0254} Meters";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loads text file
            rtbOutput.LoadFile("../test.txt", RichTextBoxStreamType.PlainText);
        }

        private void btn_spaces_Click(object sender, EventArgs e)
        {
            //loads text file and turns it into an array
            string file = "../test.txt";
            string contents = File.ReadAllText(file);
            string[] spaces = contents.Split(' ');
            string theInput = txtInput2.Text;
            int inputTwo = int.Parse(theInput);
            if (txtInput2.Text != "")
            {
                rtbOutput.Clear();

                for (int i = 0; i < spaces.Length; i += inputTwo)
                {
                    rtbOutput.Text += spaces[i] + " ";
                }
            }
            else
            {
                rtbOutput.Text += "saysomething";
            }
        }

        private void btnAlph_Click(object sender, EventArgs e)
        {
            // this splits the alpabet up and capitalizes the vowels
            string printable = "";
            string betabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] alphabet =  betabet.Split(',');
            for (int i= 0; i < alphabet.Length; i++)
            {
                if (alphabet[i].Contains("a"))
                {
                    printable = alphabet[i].Replace("a", "A");
                }
                else if (alphabet[i].Contains("e"))
                {
                    printable = alphabet[i].Replace("e", "E");
                }
                else if (alphabet[i].Contains("i"))
                {
                    printable = alphabet[i].Replace("i", "I");
                }
                else if (alphabet[i].Contains("o"))
                {
                    printable = alphabet[i].Replace("o", "O");
                }
                else if (alphabet[i].Contains("u"))
                {
                    printable = alphabet[i].Replace("u", "U");
                }
                else
                {
                    printable = alphabet[i];
                }
                if (i != 26 && i != 0)
                {
                    rtbOutput.Text += ", ";
                }
                rtbOutput.Text += printable;
            }
            rtbOutput.Text += "\n\n\n";

            //this is old code that i didnt want to delete yet


            /*
            bool done = false;
            int j = alphabet.Length;
            string printed = "";
            while(j >= 0 && done == false)
            {
                j--;
                if (j % 5 == 0 && j != alphabet.Length -1)
                {
                    rtbOutput.Text += ",";
                    for (int i = 0; i < 5; i++)
                    {

                        if(j >= 1)
                        {
                            j--;
                            printed = alphabet[j].ToUpper();
                            rtbOutput.Text += printed;
                        }
                    }
                    rtbOutput.Text += ",";
                }
                else
                {
                    printed = alphabet[j].ToLower();
                    rtbOutput.Text += printed;
                }
                if (j == 0)
                {
                    done = true;
                }
            }
            printed = alphabet[j].ToUpper();
            rtbOutput.Text += printed;
            */

            //this alternates uppercase and lowercase
            int count = 25;
            bool upper = true;

            while(count >= 0)
            {
                if(upper == true)
                {
                    rtbOutput.Text += alphabet[count].ToUpper();
                }
                else
                {
                    rtbOutput.Text += alphabet[count].ToLower();
                }
                if((count - 1) % 5 == 0)
                {
                    rtbOutput.Text += ",";
                    upper = true;
                }
                if((count - 1) % 10 == 0)
                {
                    upper = false;
                }
                count--;
            }
        }
    }
}
