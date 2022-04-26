using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace SuepLeviGame
{
    public partial class Form1 : Form
    {

        String[] leviTalk = { "Oh... Who are you?", "", "...Poop Time?", "", "Oh, I'm sorry dear.", "Did you know...", "That I love you?", "", "", "My sister in Christ,\n you made the sandwich", "", "", "That's OK, we can be together",
        "", "Through the power of ANIME!", "", "I Hope you can excuse\nme dear... I'm still new to this", "", "Will you run away with me?", "Into the great blue yonder?", ""};
        String[] suepTalk = { "", "I'm SuepTime!", "", "What? No! SUEP TIME", "", "", "", "YOU DO?", "That's kinda cringe bro.", "", "OK, good point...", "But Levi my love,\nWe are from different worlds", "",
        "But how?", "", "Levi you're being cringe again.", "", "Oh Levi, I can't get upset\nat your cringe <3", "", "", "OF COURSE LEVI!"};

        int buttonPressCount = 0;

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

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\sexymusic.wav";
            player.PlayLooping();

        }

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
    }
}
