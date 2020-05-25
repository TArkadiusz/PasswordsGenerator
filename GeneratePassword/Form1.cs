using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratePassword
{
    public partial class frmPass : Form
    {
        public frmPass()
        {
            InitializeComponent();
        }


        private void btnGen_Click(object sender, EventArgs e)
        {
            lbPass.Items.Clear();
            if (numNumber.Value == 0 || numLenght.Value == 0)
            {
                MessageBox.Show("Please enter the password length and amount of passwords", "Error", MessageBoxButtons.OK);
            }

            int lenght = Convert.ToInt32(numLenght.Value);

            string password = "";

            string allSelected = "";

            char[] numbers = new char[10]; // Utworzenie tablicy z cyframi
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToChar(i + 48);
            };

            char[] letterS = new char[26]; // Utworzenie tablicy z wielkimi literami
            for (int i = 0; i < 26; i++)
            {
                letterS[i] = Convert.ToChar(i + 65);
            };

            char[] letters = new char[26]; // Utworzenie tablicy z małymi literami
            for (int i = 0; i < 26; i++)
            {
                letters[i] = Convert.ToChar(i + 97);
            };

            char[] specialChar = new char[15]; // Utworzenie tablicy ze znakami specjalnymi
            for (int i = 0; i < 15; i++)
            {
                specialChar[i] = Convert.ToChar(i + 33);
            };

            if (rb1.Checked == true) // Jeśli zaznaczone "tylko cyfry" dodanie cyfr do zbioru
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    allSelected += numbers[i];
                }
            }

            if (rb2.Checked == true) // Jeśli zaznaczone "cyfry i litery" dodanie ich do zbioru
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    allSelected += numbers[i];
                }

                for (int i = 0; i < letterS.Length; i++)
                {
                    allSelected += letterS[i];
                }

                for (int i = 0; i < letters.Length; i++)
                {
                    allSelected += letters[i];
                }
            }

            if (rb3.Checked == true) // Jeśli zaznaczone "cyfry, litery, znaki specjalne" dodanie ich do zbioru
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    allSelected += numbers[i];
                }

                for (int i = 0; i < letters.Length; i++)
                {
                    allSelected += letters[i];
                }

                for (int i = 0; i < letterS.Length; i++)
                {
                    allSelected += letterS[i];
                }

                for (int i = 0; i < specialChar.Length; i++)
                {
                    allSelected += specialChar[i];
                }
            }

            int l = allSelected.Length;
            Random rand = new Random();
            
            for (int i = 0; i < numNumber.Value; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    password += allSelected[rand.Next(l)];
                }
                lbPass.Items.Add(password);
                password = "";
            }

            lblCopy.Text = "To copy the password, double click";
            
        }

        private void lbPass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)lbPass.SelectedItem);
        }
    }
}
