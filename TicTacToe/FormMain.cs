using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string whoseTurn = "X";

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonTopLeft.Click += Button_Click;
            buttonTopMiddle.Click += Button_Click;
            buttonTopRight.Click += Button_Click;
            buttonMiddleRight.Click += Button_Click;
            buttonMiddleMiddle.Click += Button_Click;
            buttonMiddleLeft.Click += Button_Click;
            buttonBottomRight.Click += Button_Click;
            buttonBottomMiddle.Click += Button_Click;
            buttonBottomLeft.Click += Button_Click;

            ResetGame();
        }

        void CheckForThreeInARow(Button a, Button b, Button c)
        {
            if (a.Text != "" && b.Text != "" && c.Text != "")
            {
                if (a.Text == b.Text && b.Text == c.Text)
                {
                    a.BackColor = Color.Green;
                    b.BackColor = Color.Green;
                    c.BackColor = Color.Green;

                    MessageBox.Show($"{a.Text} is the winner!");
                    ResetGame();
                }
            }
        }

        void ResetGame()
        {
            buttonTopLeft.Text = "";
            buttonTopMiddle.Text = "";
            buttonTopRight.Text = "";
            buttonMiddleRight.Text = "";
            buttonMiddleMiddle.Text = "";
            buttonMiddleLeft.Text = "";
            buttonBottomRight.Text = "";
            buttonBottomMiddle.Text = "";
            buttonBottomLeft.Text = "";

            buttonTopLeft.BackColor = SystemColors.ButtonFace;
            buttonTopMiddle.BackColor = SystemColors.ButtonFace;
            buttonTopRight.BackColor = SystemColors.ButtonFace;
            buttonMiddleRight.BackColor = SystemColors.ButtonFace;
            buttonMiddleMiddle.BackColor = SystemColors.ButtonFace;
            buttonMiddleLeft.BackColor = SystemColors.ButtonFace;
            buttonBottomRight.BackColor = SystemColors.ButtonFace;
            buttonBottomMiddle.BackColor = SystemColors.ButtonFace;
            buttonBottomLeft.BackColor = SystemColors.ButtonFace;

            whoseTurn = "X";

            labelTurn.Text = $"It is {whoseTurn}s turn!";
        }

        void CheckForWin()
        {
            //Check rows for wins:
            CheckForThreeInARow(buttonTopLeft, buttonTopMiddle, buttonTopRight);
            CheckForThreeInARow(buttonMiddleLeft, buttonMiddleMiddle, buttonMiddleRight);
            CheckForThreeInARow(buttonBottomLeft, buttonBottomMiddle, buttonBottomRight);

            //Check columns for wins:
            CheckForThreeInARow(buttonTopLeft, buttonMiddleLeft, buttonBottomLeft);
            CheckForThreeInARow(buttonTopMiddle, buttonMiddleMiddle, buttonBottomMiddle);
            CheckForThreeInARow(buttonTopRight, buttonMiddleRight, buttonBottomRight);

            //Check across for wins:
            CheckForThreeInARow(buttonTopLeft, buttonMiddleMiddle, buttonBottomRight);
            CheckForThreeInARow(buttonBottomLeft, buttonMiddleMiddle, buttonTopRight);

            if (buttonTopLeft.Text != "" &&
                buttonTopMiddle.Text != "" &&
                buttonTopRight.Text != "" &&
                buttonMiddleRight.Text != "" &&
                buttonMiddleMiddle.Text != "" &&
                buttonMiddleLeft.Text != "" &&
                buttonBottomRight.Text != "" &&
                buttonBottomMiddle.Text != "" &&
                buttonBottomLeft.Text != "")
            {
                MessageBox.Show($"You both suck!");
                ResetGame();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);

            if (button.Text != "")
            {
                return;
            }

            button.Text = whoseTurn;

            if (whoseTurn == "X")
            {
                whoseTurn = "O";
            }
            else
            {
                whoseTurn = "X";
            }

            CheckForWin();

            labelTurn.Text = $"It is {whoseTurn}s turn!";
        }
    }
}