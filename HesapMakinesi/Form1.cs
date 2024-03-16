using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        char _islem;  //her yerde geçerli olduğu belli olsun 
        bool _ekranTemizlenecekMi;
        int _ilkSayi; 

        public Form1()
        {
            InitializeComponent();
        }
        
        


        private void rakam1Button_Click(object sender, EventArgs e)
        {   
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = ""; 
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = ""; 
                
            }
            ekranLabel.Text += "1";


        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";




            }
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
               
            }
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
                
            }
            ekranLabel.Text += "5";

        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
                
            }
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
                
            }
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
                
            }

            ekranLabel.Text = "8"; 



        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";




            }
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
                
            }
            ekranLabel.Text += "0";
        }

        private void toplamaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text); 

        }
        private void cikarmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text); 
        }
        private void carpımButton_Click(object sender, EventArgs e)
        {
            _islem = 'X';
            _ekranTemizlenecekMi = true;
            _ilkSayi =  Convert.ToInt32(ekranLabel.Text);
            

        }
        private void bolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text); 
        }

        private void esitButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc; 
            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi; 
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                case 'X':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break; 

            }
            ekranLabel.Text = Convert.ToString(sonuc); 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0"; 
        }
    }
}
