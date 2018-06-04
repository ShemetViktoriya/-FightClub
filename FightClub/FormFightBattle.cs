using System;
using System.Windows.Forms;

namespace FightClub
{
    public partial class FormFightBattle : Form
    {
        Human human = new Human(Data.ValueName);
        Computer computer = new Computer("Computer");
        Game game;

        //Declaring the variables for this game
        bool IsAttack = true;

        public FormFightBattle()
        {
            InitializeComponent();
            btnHead.Click += button_Click;
            btnTorso.Click += button_Click;
            btnLegs.Click += button_Click;
            NewGame();
            lblHuman.Text = Data.ValueName;
            lblRoundsPlayed.Text = game.roundsPlayed.ToString();
            lblHumanHp.Text = game.humanHp.ToString();
            lblComputerHp.Text = game.computerHp.ToString();
            lblAtPr.Text = "Attack enemy";

            // progressbar for Player
            progressBarPlayer.Minimum = 0;
            progressBarPlayer.Maximum = human.Hp;
            progressBarPlayer.Value = human.Hp;
            lblHumanHp.Text = computer.Hp.ToString();

            // progressbar for Computer
            progressBarComputer.Minimum = 0;
            progressBarComputer.Maximum = computer.Hp;
            progressBarComputer.Value = computer.Hp;
            lblComputerHp.Text = computer.Hp.ToString();
        }

        private void NewGame()
        {
            game = new Game(human, computer);
            game.RoundFinished += game_RoundFinished;
            game.GameFinished += game_GameFinished;
            lblRoundsPlayed.Text = game.roundsPlayed.ToString();
            lblHumanHp.Text = game.humanHp.ToString();
            lblComputerHp.Text = game.computerHp.ToString();
            pctBoxComputer.Image = Properties.Resources.Question;
            pctBoxHuman.Image = Properties.Resources.Question;
            LblWhoWon.Text = "";
            lblPlayerAction.Text = "";
            lblComputerAction.Text = "";
            human.Play();
        }

        void game_RoundFinished(object sender, EventArgs e)
        {
            if (game.isGameOver != true)
            {
                lblRoundsPlayed.Text = game.roundsPlayed.ToString();
                lblHumanHp.Text = game.humanHp.ToString();
                lblComputerHp.Text = game.computerHp.ToString();

                progressBarPlayer.Value = game.humanHp;
                progressBarComputer.Value = game.computerHp;

                switch (game.Computer.BlockBodyPart)
                {
                    case BodyPart.Head:
                        pctBoxComputer.Image = Properties.Resources.Head;
                        break;
                    case BodyPart.Torso:
                        pctBoxComputer.Image = Properties.Resources.Torso;
                        break;
                    case BodyPart.Legs:
                        pctBoxComputer.Image = Properties.Resources.Legs;
                        break;
                    default:
                        break;
                }

                if (!IsAttack)
                {
                    lblPlayerAction.Text = "What Player Blocked";
                    lblComputerAction.Text = "Where Computer Hited";
                }
                else
                {
                    lblPlayerAction.Text = "Where Player Hited";
                    lblComputerAction.Text = "What Computer Blocked";
                }

                if (game.isTie)
                    LblWhoWon.Text = "Tie";
                else if (game.humanWon)
                    LblWhoWon.Text = "Human";
                else
                    LblWhoWon.Text = "Computer";
            }
        }


        void game_GameFinished(object sender, EventArgs e)
        {
            if (game.isGameOver)
            {
                if (game.humanHp > 0)
                    NameWinner.Text = "Battle won "+human.Name;
                else
                    NameWinner.Text = "Battle won " + computer.Name;
            }   
        }


        private void button_Click(object sender, EventArgs e)
        {
            if (game.isGameOver != true)
            {
                Button button = sender as Button;
                pctBoxComputer.Image = Properties.Resources.Question;
                if (!IsAttack)
                {
                    lblPlayerAction.Text = "Where Player Hits";
                    lblComputerAction.Text = "What Computer Blocks";
                    human.UserProtect((BodyPart)Enum.Parse(typeof(BodyPart), button.Text));
                    switch (human.BlockBodyPart)
                    {
                        case BodyPart.Head:
                            pctBoxHuman.Image = Properties.Resources.Head;
                            break;
                        case BodyPart.Torso:
                            pctBoxHuman.Image = Properties.Resources.Torso;
                            break;
                        case BodyPart.Legs:
                            pctBoxHuman.Image = Properties.Resources.Legs;
                            break;
                        default:
                            break;
                    }
                    lblAtPr.Text = "Attack enemy";
                }
                else
                {
                    human.UserAttack((BodyPart)Enum.Parse(typeof(BodyPart), button.Text));
                    switch (human.HitEnemyBodyPart)
                    {
                        case BodyPart.Head:
                            pctBoxHuman.Image = Properties.Resources.Head;
                            break;
                        case BodyPart.Torso:
                            pctBoxHuman.Image = Properties.Resources.Torso;
                            break;
                        case BodyPart.Legs:
                            pctBoxHuman.Image = Properties.Resources.Legs;
                            break;
                        default:
                            break;
                    }
                    lblAtPr.Text = "Protect yourself";
                }
                IsAttack = !IsAttack;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Game Fight Club.");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
