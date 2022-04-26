using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuepLeviGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (buttonPressCount == 0){
                button2.BackColor = Color.Gray;
            }
            else
            {
                button2.BackColor = Color.IndianRed;
            }
        }

        String[] leviTalk = { "Oh... Who are you?", "", "...Poop Time?", "", "Oh, I'm sorry dear.", "Did you know...", "That I love you?", "", "", "My sister in Christ,\n you made the sandwhich", "", "", "That's OK, we can be together",
        "", "Throught the power of ANIME!", ""};
        String[] suepTalk = { "", "I'm SuepTime!", "", "What? No! SUEP TIME", "", "", "", "YOU DO?", "That's kinda cringe bro.", "", "OK, good point...", "But Levi my love,\nWe are from different worlds", "",
        "But how?", "", "Levi you're being cringe again."};

        int buttonPressCount = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                leviTxt.Text = (leviTalk[buttonPressCount]);
                suepTxt.Text = (suepTalk[buttonPressCount]);
                if (buttonPressCount <= leviTalk.Length)
                {
                    buttonPressCount += 1;
                    button1.BackColor = Color.IndianRed;
                    button2.BackColor = Color.IndianRed;
                }
                else
                {
                    Console.WriteLine("Nope");
                    button1.BackColor = Color.Gray;
                    button2.BackColor = Color.Gray;
                }
                if (buttonPressCount == leviTalk.Length)
                {
                    button1.BackColor = Color.Gray;

                }
            }
            catch
            {
                Console.WriteLine("oops");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonPressCount > 0)
                {
                    buttonPressCount -= 1;
                    button2.BackColor = Color.IndianRed;
                }
                else
                {
                    Console.WriteLine("Nope");
                    button2.BackColor = Color.Gray;
                }
                leviTxt.Text = (leviTalk[buttonPressCount]);
                suepTxt.Text = (suepTalk[buttonPressCount]);
            }
            catch
            {
                Console.WriteLine("oops");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            buttonPressCount = 0;
            leviTxt.Text = "";
            suepTxt.Text = "";
            button2.BackColor = Color.Gray;
            button1.BackColor = Color.IndianRed;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}//end
