using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;
using static System.Windows.Forms.AxHost;

namespace Tic_Tac_Toe_Game
{
    public partial class MainForm : Form
    {
        bool Player_1 = true;
        static string Player_One = "Player 1";
        string ID_Player_One = "1";
        static string Player_Two = "Player 2";
        string ID_Player_Two = "2";
        int Draw = 0;
        bool Disable_Enable = true;
        string Card_Description;
        string Card_Text;


        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsDraw()
        {
            if (Draw == 9)
            {
                label_Turn_For_Player.Text = " ";
                label_UnderProgress.ForeColor = Color.FromArgb(255, 255, 128);
                Card_Text = "No Winner";
                Card_Description = "It's Draw !";
                label_UnderProgress.Text = $"{Card_Text}";
                Disable_Enable_Picture_boxes(!Disable_Enable);
                return true;
            }
            return false;
        }

        private void Return_Picture_Box_Properties()
        {
            
            pictureBox1.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox2.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox3.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox4.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox5.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox6.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox7.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox8.BackgroundImage = Resources.question_mark_5726775_removebg_preview;
            pictureBox9.BackgroundImage = Resources.question_mark_5726775_removebg_preview;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;

            pictureBox1.Tag = "0";
            pictureBox2.Tag = "0";
            pictureBox3.Tag = "0";
            pictureBox4.Tag = "0";
            pictureBox5.Tag = "0";
            pictureBox6.Tag = "0";
            pictureBox7.Tag = "0";
            pictureBox8.Tag = "0";
            pictureBox9.Tag = "0";
        }

        private void Disable_Enable_Picture_boxes(bool Disable) {
            pictureBox2.Enabled = Disable;
            pictureBox1.Enabled = Disable;
            pictureBox3.Enabled = Disable;
            pictureBox4.Enabled = Disable;
            pictureBox5.Enabled = Disable;
            pictureBox6.Enabled = Disable;
            pictureBox7.Enabled = Disable;
            pictureBox8.Enabled = Disable;
            pictureBox9.Enabled = Disable;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Draw++;
            var pictureBox = sender as PictureBox;
            if (Player_1)
            {
                pictureBox.BackgroundImage = Properties.Resources.O;
                pictureBox.Tag = ID_Player_One;
                if (!GameLogic())
                {
                    label_Turn_For_Player.ForeColor = Color.Red;
                    label_Turn_For_Player.Text = Player_Two;
                }          
            }
            else
            {
                pictureBox.BackgroundImage = Properties.Resources.X;
                pictureBox.Tag = ID_Player_Two;
                if (!GameLogic())
                {
                    label_Turn_For_Player.ForeColor = Color.Lime;
                    label_Turn_For_Player.Text = Player_One;
                }            
            }
            pictureBox.Enabled = false;
            Player_1 = !Player_1;
        }

        private bool GameLogic()
        {
            // Check horizontal lines
            if (IsWinningCombination(pictureBox1, pictureBox2, pictureBox3) ||
                IsWinningCombination(pictureBox4, pictureBox5, pictureBox6) ||
                IsWinningCombination(pictureBox7, pictureBox8, pictureBox9))
            {
                MessageBox.Show(Card_Text,Card_Description,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }

            // Check vertical lines
           else if (IsWinningCombination(pictureBox1, pictureBox6, pictureBox7) ||
                IsWinningCombination(pictureBox2, pictureBox5, pictureBox8) ||
                IsWinningCombination(pictureBox3, pictureBox4, pictureBox9))
            {
                MessageBox.Show(Card_Text, Card_Description, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            // Check diagonal lines
           else if (IsWinningCombination(pictureBox1, pictureBox5, pictureBox9) ||
                IsWinningCombination(pictureBox3, pictureBox5, pictureBox7))
            {
                MessageBox.Show(Card_Text, Card_Description, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (IsDraw())
            {
                MessageBox.Show(Card_Text, Card_Description, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private bool IsWinningCombination(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag.ToString() == ID_Player_One && pb2.Tag.ToString() == ID_Player_One && pb3.Tag.ToString() == ID_Player_One)
            {
                pb1.BackColor = Color.Lime;
                pb2.BackColor = Color.Lime;
                pb3.BackColor = Color.Lime;
                label_Turn_For_Player.Text = "";
                label_UnderProgress.ForeColor = label_Turn_For_Player.ForeColor;
                Card_Text = $"{Player_One} Wins !";
                Card_Description = "Winning Card";
                label_UnderProgress.Text = $"{Card_Text}";
                Disable_Enable_Picture_boxes(!Disable_Enable);
                return true;
            }
           else if (pb1.Tag.ToString() == ID_Player_Two && pb2.Tag.ToString() == ID_Player_Two && pb3.Tag.ToString() == ID_Player_Two)
            {
                pb1.BackColor = Color.Red;
                pb2.BackColor = Color.Red;
                pb3.BackColor = Color.Red;
                label_Turn_For_Player.Text = "";
                label_UnderProgress.ForeColor = label_Turn_For_Player.ForeColor;
                Card_Text = $"{Player_Two} Wins !";
                Card_Description = "Winning Card";
                label_UnderProgress.Text = $"{Card_Text}";
                Disable_Enable_Picture_boxes(!Disable_Enable);
                return true;
            } 
            return false;
        }

        private void Draw_Lines(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;

            // Vertical lines
            e.Graphics.DrawLine(pen, 550, 67, 550, 471); // First vertical line
            e.Graphics.DrawLine(pen, 738, 67, 738, 471); // First vertical line
            // Horizontal lines
            e.Graphics.DrawLine(pen, 414, 190, 860, 190); // First horizontal line
            e.Graphics.DrawLine(pen, 414, 345, 860, 345); // Second horizontal line
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Start_Again_Click(object sender, EventArgs e)
        {
            Disable_Enable_Picture_boxes(Disable_Enable);
            Return_Picture_Box_Properties();
            label_Turn_For_Player.Text = Player_One;
            label_Turn_For_Player.ForeColor = Color.Lime;
            label_UnderProgress.Text = "Under Progress";
            label_UnderProgress.ForeColor = Color.Gray;
            Draw = 0;
        }

        private void Github_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AhmedMohamed-1");
        }
        
        private void Linkedin_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com/in/ahmed-mohamed-0a6086285");
        }
    }
}
