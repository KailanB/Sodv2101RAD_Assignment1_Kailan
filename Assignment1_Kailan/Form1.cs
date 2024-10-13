namespace Assignment1_Kailan
{


    public partial class Form1 : Form
    {
        // this bool is used to stop players from taking actions while the game is displaying a new sequence
        private bool displaying = false;
        // this bool is used to stop players from spamming next sequence and make sure game steps are done in proper order
        private bool awaitingUserSequence = false;

        private bool gameOver = false;

        private int highScore = 0;
        private string highScorePlayerName;

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
            // once the game is finished displaying the sequence and flags awaiting user input
            if (!displaying && awaitingUserSequence)
            {
                // each button curresponds to a number
                // add to buttonSequencePlayer array to compare their choices with the games randomized sequence
                if (btn.Name == "btnBlue")
                {
                    GameSequence.ButtonSequencePlayer.Add(1);
                }
                if (btn.Name == "btnGreen")
                {
                    GameSequence.ButtonSequencePlayer.Add(2);
                }
                if (btn.Name == "btnOrange")
                {
                    GameSequence.ButtonSequencePlayer.Add(3);
                }
                if (btn.Name == "btnPurple")
                {
                    GameSequence.ButtonSequencePlayer.Add(4);
                }
                // every time player presses a button check sequence to make sure they have pressed buttons in the correct order
                if(GameSequence.CheckButtonPress())
                {
                    if (GameSequence.CheckSequenceFinished())
                    {
                        lblResult.Text = $"Result: Sequence correct!";
                        lblYourScore.Text = $"Your Score: {GameSequence.ButtonSequence.Count}";
                        awaitingUserSequence = false;

                    }
                }
                else
                {
                    gameOver = true;
                    int playerScore = GameSequence.ButtonSequence.Count - 1;
                    lblResult.Text = "Result: Game over! Sequence Incorrect!!";
                    lblYourScore.Text = $"Your Score: {playerScore}";
                    if (playerScore > GameSequence.HighScore)
                    {
                        
                        lblNewHighScore.Text = $"NEW HIGH SCORE {playerScore}";
                        lblCurrentHighScore.Text = $"High Score: {playerScore}";
                        AddHighScoreName addHighScoreForm = new AddHighScoreName();
                        if(addHighScoreForm.ShowDialog() == DialogResult.OK)
                        {
                            GameSequence.HighScore = playerScore;
                            string playerName = addHighScoreForm.InputName;
                            GameSequence.PlayerHighScoreList.Add(new Player(playerName, playerScore));
                            /* GameSequence.PlayerHighScoreList.OrderByDescending(player => player.Score).ToList();*/
                            GameSequence.PlayerHighScoreList.Reverse();
                        }
                        txtHighScoreList.Text = "";
                        foreach (Player player in GameSequence.PlayerHighScoreList)
                        {
                            txtHighScoreList.Text += player.ToString();
                        }
                        
                    }
                    awaitingUserSequence = false;
                   /* GameSequence.ResetGame();*/
                }
                
                
            } 
        }

        // How to delay code in C# https://stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
        public async void ChangeBtnOrangeColor(int delayIncrease)
        {
            // delay increase value received from the for loop value.
            // for each iteration of the loop we have a longer delay 
            // this makes sure that the buttons flash in the correct order with a delay
            await Task.Delay(1100 * delayIncrease);
            btnOrange.BackColor = Color.LightSalmon;
            // change button color back after another delay
            await Task.Delay(800);
            btnOrange.BackColor = Color.OrangeRed;
        }

        // each function works the same but is assigned to a different button since they all change different colors
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

        // this function starts the next sequence display when the user is ready.
        // this allows a user to pause and take a break if they wish
        private async void btnShowNextSequence_Click(object sender, EventArgs e)
        {
            if (!awaitingUserSequence)
            {
                if (!displaying && !gameOver)
                {
                    lblResult.Text = "Result:";
                    displaying = true;
                    GameSequence.DisplayNextSequence(this);
                    // add a delay before setting displaying to false and allowing the player to click the buttons again
                    // this delay is increased based on the size of the array
                    await Task.Delay(GameSequence.ButtonSequence.Count * 1100);
                    // after all is finished the player will be allowed to input their sequence
                    displaying = false;
                    awaitingUserSequence = true;
                }
                else
                {
                    // do nothing wait for displaying
                }
            }

        }



        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            gameOver = false;
            awaitingUserSequence = false;
            lblResult.Text = "Result: ";
            lblYourScore.Text = "Your Score: ";
            lblNewHighScore.Text = "";
            GameSequence.ResetGame();
        }
    }


    static class GameSequence
    {
        public static Random rnd = new Random();

        public static List<int> ButtonSequence = new List<int>();
        public static List<int> ButtonSequencePlayer = new List<int>();
        public static bool gameOver = false;
        public static int HighScore = 0;

        public static List<Player> PlayerHighScoreList = new List<Player>();

        

        public static void ResetGame()
        {
            gameOver = false;
            ButtonSequencePlayer.Clear();
            ButtonSequence.Clear();
        }

       

        public static void DisplayNextSequence(Form1 form)
        {

            // adds a new random value to the sequence
            ButtonSequence.Add(rnd.Next(1, 5));
            for (int i = 0; i < ButtonSequence.Count; i++)
            {

                // MessageBox.Show(buttonSequence[i].ToString());
                // change color of correct button by sending the value saved in the array
                switch (ButtonSequence[i])
                {
                    case 1:
                        // send i value to this function which increases the delay between each button flash
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

        public static bool CheckButtonPress()
        {
            // check last button press player made, compared to the corresponding button index of the game sequence
            if (ButtonSequencePlayer.Last() != ButtonSequence[ButtonSequencePlayer.Count - 1])
            {
                
                return false;
                
            }
            else
            {
                return true;
            }
        }

        public static bool CheckSequenceFinished()
        {

            /*
             * highScore = buttonSequence.Count - 1;
             * lblHighScore.Text = (buttonSequence.Count - 1).ToString();
             * lblYourScore.Text += "\nNEW HIGH SCORE!";
             */
            if (ButtonSequencePlayer.Count == ButtonSequence.Count)
            {
                ButtonSequencePlayer.Clear();
                return true;
            }
            else
            {
                return false;
            }
            /*lblResult.Text = $"Result:\r\nSequence correct!\r\nButtons memorized: {playerSeq.Count}";
            txtYourSequence.Text = "";
            playerSeq.Clear();*/
            

        }
       


    }

    public class Player
    {
        public string Name { get; private set; }
        public  int Score { get; private set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;

        }

        public override string ToString()
        {
            return $"{Name}: {Score}\r\n";
        }



    }

}

