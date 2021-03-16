using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class pwgen : Form
    {
        public pwgen()
        {
            InitializeComponent();
            label1.Text = "Len: " + lenBar.Value.ToString();
            pwListBox.Items.Clear();
            pwListBox.Items.Add("none");
        }

        public int itemCtr = 0;

        char[,] letters = new char[,] { { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't' },
            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' } };

        char[] specials = { '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '[', '}', ']', '|', '\\', ':', ';', '<', ',', '>', '.', '?', '/' };

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] p = new char[lenBar.Value];
            Random r = new Random();

            for (int i = 0; i < lenBar.Value; i++)
            {
                p[i] = letters[r.Next(2), r.Next(18)];

                if (numbersCheck.Checked)
                {
                    if (i < lenBar.Value-1)
                        i++;
                    p[i] = r.Next(0, 9).ToString().ToCharArray()[0];
                }

                if (specialsCheck.Checked)
                {
                    if (i < lenBar.Value-1)
                        i++;
                    p[i] = specials[r.Next(0, 30)];
                }
            }

            string a = nameTextBox.Text + " | ";
            passBox.Text = "";
            for (int I = 0; I < lenBar.Value; I++)
            {
                passBox.Text += p[I];
                a += p[I];
            }

            pwListBox.Items.Remove("none");
            pwListBox.Items.Add(a);

        }

        private void pwListBox_Click(object sender, EventArgs e)
        {
            if (pwListBox.Items.Count > 0)
            {
                if (pwListBox.SelectedIndex < 0)
                    pwListBox.SelectedIndex = 0;
                Clipboard.SetData(DataFormats.StringFormat, pwListBox.SelectedItem.ToString());
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lenBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Len: " + lenBar.Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            pwListBox.Items.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] txt;
            txt = new string[pwListBox.Items.Count];

            for (int i = 0; i < pwListBox.Items.Count; i++)
            {
                pwListBox.SetSelected(i, true);
                txt[i] = pwListBox.SelectedItem.ToString();
            }
            
            System.IO.File.WriteAllLines(@"Passwords.txt", txt);
        }

        private void delSelectedBtn_Click(object sender, EventArgs e)
        {
            if (pwListBox.Items.Count > 0)
            {
                if (pwListBox.SelectedIndex < 0)
                    pwListBox.SelectedIndex = 0;
                pwListBox.Items.RemoveAt(pwListBox.SelectedIndex);
            }
        }
    }
}
