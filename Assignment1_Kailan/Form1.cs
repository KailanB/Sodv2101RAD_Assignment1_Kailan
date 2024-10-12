namespace Assignment1_Kailan
{


    public partial class Form1 : Form
    {
        private bool displaying = false;
        private bool awaitingUserSequence = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnColours_MouseDown(object sender, MouseEventArgs e)
        {
            // how to refer to object sender as a Button
            // https://www.codeproject.com/Questions/578845/howplustoplusgetplusbuttonplusnamepluswithplussend 
            Button btn = (Button)sender;
            // displaying checks if the program is currently displaying a light up sequence.
            // buttons should not be pressed during this sequence
            if (!displaying)
            {
                if (btn.Name == "btnBlue")
                {
                    btnBlue.BackColor = Color.CornflowerBlue;
                }
                if (btn.Name == "btnGreen")
                {
                    btnGreen.BackColor = Color.LawnGreen;
                }
                if (btn.Name == "btnOrange")
                {
                    btnOrange.BackColor = Color.LightSalmon;
                }
                if (btn.Name == "btnPurple")
                {
                    btnPurple.BackColor = Color.BlueViolet;
                }
            }

        }
        private void btnColours_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (!displaying)
            {
                if (btn.Name == "btnBlue")
                {
                    btnBlue.BackColor = Color.RoyalBlue;
                }
                if (btn.Name == "btnGreen")
                {
                    btnGreen.BackColor = Color.ForestGreen;
                }
                if (btn.Name == "btnOrange")
                {
                    btnOrange.BackColor = Color.OrangeRed;
                }
                if (btn.Name == "btnPurple")
                {
                    btnPurple.BackColor = Color.Indigo;
                }
            }

        }

        private void btnColours_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!displaying)
            {
                if (btn.Name == "btnBlue")
                {
                    GameSequence.buttonSequencePlayer.Add(1);
                    txtYourSequence.Text += "Blue\r\n";
                }
                if (btn.Name == "btnGreen")
                {
                    GameSequence.buttonSequencePlayer.Add(2);
                    txtYourSequence.Text += "Green\r\n";
                }
                if (btn.Name == "btnOrange")
                {
                    GameSequence.buttonSequencePlayer.Add(3);
                    txtYourSequence.Text += "Orange\r\n";
                }
                if (btn.Name == "btnPurple")
                {
                    GameSequence.buttonSequencePlayer.Add(4);
                    txtYourSequence.Text += "Purple\r\n";
                }
            }
        }

        // How to delay code in C# https://stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
        public async void ChangeBtnOrangeColor(int delayIncrease)
        {
            await Task.Delay(1100 * delayIncrease);
            btnOrange.BackColor = Color.LightSalmon;
            await Task.Delay(800);
            btnOrange.BackColor = Color.OrangeRed;
        }
        public async void ChangeBtnPurpleColor(int delayIncrease)
        {
            await Task.Delay(1100 * delayIncrease);
            btnPurple.BackColor = Color.BlueViolet;
            await Task.Delay(800);
            btnPurple.BackColor = Color.Indigo;

        }
        public async void ChangeBtnBlueColor(int delayIncrease)
        {
            await Task.Delay(1100 * delayIncrease);
            btnBlue.BackColor = Color.CornflowerBlue;
            await Task.Delay(800);
            btnBlue.BackColor = Color.RoyalBlue;
        }
        public async void ChangeBtnGreenColor(int delayIncrease)
        {
            await Task.Delay(1100 * delayIncrease);
            btnGreen.BackColor = Color.LawnGreen;
            await Task.Delay(800);
            btnGreen.BackColor = Color.ForestGreen;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if(!awaitingUserSequence)
            {
                if (!displaying)
                {
                    displaying = true;
                    GameSequence.DisplayNextSequence(this);
                    await Task.Delay(GameSequence.buttonSequence.Count * 1100);
                    displaying = false;
                    awaitingUserSequence = true;
                }
                else
                {
                    // do nothing wait for displaying
                }
            }

        }

        private void btnClearYourSequence_Click(object sender, EventArgs e)
        {
            GameSequence.buttonSequencePlayer.Clear();
            txtYourSequence.Text = "";
        }

        private void btnCheckSequence_Click(object sender, EventArgs e)
        {
            if (!displaying)
            {
                awaitingUserSequence = false;
                List<int> playerSeq = GameSequence.buttonSequencePlayer;
                List<int> gameSeq = GameSequence.buttonSequence;
                if ((playerSeq.Count > 0) && gameSeq.Count > 0)
                {
                    for (int i = 0; i < playerSeq.Count; i++)
                    {
                        if (playerSeq[i] != gameSeq[i])
                        {

                            lblResult.Text = "Result:\r\nGame over! Sequence Incorrect!!";
                            lblYourScore.Text += $"Your Score: {gameSeq.Count - 1}";
                            playerSeq.Clear();
                            gameSeq.Clear();
                            return;
                        }
                        else
                        {

                        }
                    }
                    lblResult.Text = $"Result:\r\nSequence correct!\r\nButtons memorized: {playerSeq.Count}";
                    txtYourSequence.Text = "";
                    playerSeq.Clear();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            awaitingUserSequence = false;
            txtYourSequence.Text = "";
            lblResult.Text = "Result: ";
            lblYourScore.Text = "";
            GameSequence.ResetGame();
        }
    }


    class GameSequence
    {
        public static Random rnd = new Random();

        public static List<int> buttonSequence = new List<int>();
        public static List<int> buttonSequencePlayer = new List<int>();
        public static bool gameOver = false;

        public static void ResetGame()
        {
            gameOver = false;
            buttonSequence.Clear();
        }

        public static void DisplayNextSequence(Form1 form)
        {

            buttonSequence.Add(rnd.Next(1, 5));
            for (int i = 0; i < buttonSequence.Count; i++)
            {

                // MessageBox.Show(buttonSequence[i].ToString());
                switch (buttonSequence[i])
                {
                    case 1:
                        form.ChangeBtnBlueColor(i);
                        break;

                    case 2:
                        form.ChangeBtnGreenColor(i);
                        break;

                    case 3:
                        form.ChangeBtnOrangeColor(i);
                        break;

                    case 4:
                        form.ChangeBtnPurpleColor(i);
                        break;
                    default:
                        break;
                }
                

            }
        }


    }
}
