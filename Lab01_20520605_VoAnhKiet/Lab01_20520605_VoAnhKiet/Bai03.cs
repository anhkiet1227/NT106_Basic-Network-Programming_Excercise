using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_20520605_VoAnhKiet
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        class myClass
        {
            public bool checkBillion = false;
            public bool checkMillion = false;
            public bool checkThousand = false;
            public bool checkHundred = false;
        }

        public static string numberToWords(int nNumber)
        {
            myClass myInstance = new myClass();

            

            if (nNumber < 0)
                return "âm " + numberToWords(Math.Abs(nNumber));

            
            if (nNumber == 0)
                return "không";

            switch(nNumber)
            {                              
                case 1:
                    return "một";
                case 2:
                    return "hai";
                case 3:
                    return "ba";
                case 4:
                    return "bốn";
                case 5:
                    return "năm";
                case 6:
                    return "sáu";
                case 7:
                    return "bảy";
                case 8:
                    return "tám";
                case 9:
                    return "chín";
                case 10:
                    return "mười";
                case 11:
                    return "mười một";
                case 12:
                    return "mười hai";
                case 13:
                    return "mười ba";
                case 14:
                    return "mười bốn";
                case 15:
                    return "mười lăm";
                case 16:
                    return "mười sáu";
                case 17:
                    return "mười bảy";
                case 18:
                    return "mười tám";
                case 19:
                    return "mười chín";
                case 20:
                    return "hai mươi";
                case 100:
                    return "một trăm";
                case 1000:
                    return "một ngàn";
                case 10000:
                    return "mười ngàn";
                case 100000:
                    return "một trăm ngàn";
                case 1000000:
                    return "một triệu";
                case 10000000:
                    return "mười triệu";
                case 100000000:
                    return "một trăm triệu";
                case 1000000000:
                    return "một tỷ";
            }
            string nReader = "";
            var toTen = new[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín", };
            var doZens = new[] { "không", "mười ", "hai mươi ", "ba mươi ", "bốn mươi ", "năm mươi ", "sáu mươi ", "bảy mươi ", "tám mươi ", "chín mươi " };
            
            
            if (nNumber > 19 && nNumber < 100)
            {
                int i = nNumber / 10;
                nReader = nReader + doZens[i] + " ";
                nNumber = nNumber % 10;                
            }
            if (nNumber <= 19)
            {
                nReader += toTen[nNumber];
                return nReader;
            }   

            if ((nNumber / 1000000000) > 0  )
            {
                if (nNumber >= 1000000)
                    myInstance.checkBillion = true;
                nReader += numberToWords(nNumber / 1000000000) + " tỷ ";
                nNumber %= 1000000000;
                
            }
            

            if ((nNumber / 1000000) > 0)
            {
                if((nNumber / 1000000) == 0 && myInstance.checkBillion == true && (nNumber >= 1000))
                { 
                    nReader += " không triệu ";                    
                }
                else
                {
                    myInstance.checkMillion = true;
                    nReader += numberToWords(nNumber / 1000000) + " triệu ";
                    nNumber %= 1000000;                    
                }                           
            }

            if ((nNumber / 1000) > 0)
            {
                if ((nNumber / 1000) == 0 && myInstance.checkMillion == true && (nNumber >= 100))
                {
                    nReader += " không ngàn ";
                }
                else
                {
                    
                    nReader += numberToWords(nNumber / 1000) + " ngàn ";
                    myInstance.checkThousand = true;
                    nNumber %= 1000;
                }                 
            }
            
            if ((nNumber / 100) >= 0)
            {
                if ((nNumber / 100) == 0 && myInstance.checkThousand == true)
                {
                    nReader += "không trăm ";
                }
                else
                {
                    myInstance.checkHundred = true;
                    nReader += numberToWords(nNumber / 100) + " trăm ";
                    nNumber %= 100;
                }
                
            }

            if (nNumber >= 0)
            {
                if (nNumber < 10 && myInstance.checkHundred == true)
                    nReader += "lẻ " + toTen[nNumber];             
                else
                {
                    nReader += doZens[nNumber / 10];
                    if ((nNumber % 10) > 0)
                        nReader += toTen[nNumber % 10];
                }
            }           

            return nReader;

        } 


        private void button1_Click(object sender, EventArgs e)
        {
            int nNumber;
            string nReader = "";
            try
            {
                nNumber = Int32.Parse(textBox1.Text.Trim());
                nReader = numberToWords(nNumber);
                textBox2.Text = nReader;
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Caution: ERROR! Check your input again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
