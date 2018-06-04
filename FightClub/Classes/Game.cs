using System;
using System.Windows.Forms;

namespace FightClub
{
    class Game
    {
        public delegate void RoundFinishedDelegate(object sender, EventArgs e);
        public event RoundFinishedDelegate RoundFinished;



        public delegate void GameFinishedDelegate(object sender, EventArgs e);
        public event GameFinishedDelegate GameFinished;




        public int roundsPlayed { get; private set; }
        public int humanHp { get; private set; }
        public int computerHp { get; private set; }

        public bool computerWon { get; private set; }
        public bool humanWon { get; private set; }
        public bool isTie { get; private set; }
        public bool isAttack { get; set; }
        public bool isGameOver { get; private set; }

        public IPlayer Human { get; private set; }
        public IPlayer Computer { get; private set; }

        public Game(Player human, Player computer)
        {
            Human = (IPlayer)human;
            Computer = (IPlayer)computer;
            roundsPlayed = 0;
            humanHp = human.Hp;
            computerHp = computer.Hp;
            Human.Played += human_Played;
            Computer.Played += computer_Played;
            isAttack = true;
            isGameOver = false;
        }

        void computer_Played(object sender, BodyPart bodyPart)
        {
            CheckGameOver();
            CheckHasWin();
            Human.Play();
            isAttack = !isAttack;
        }

        void human_Played(object sender, BodyPart bodyPart)
        {
            Computer.Play();
        }


        void CheckHasWin()
        {
            isTie = false;
            computerWon = false;
            humanWon = false;
            if (!isAttack)
            {
                if (Human.BlockBodyPart != Computer.HitEnemyBodyPart)
                {
                    computerWon = true;
                    humanHp -= 10; //computerWins
                }
                else isTie = true;
            }
            else
            {
                if (Human.HitEnemyBodyPart != Computer.BlockBodyPart)
                {
                    humanWon = true;
                    computerHp -= 10; //humanWins
                }
                else isTie = true;
            }
            roundsPlayed++;
            RoundFinished?.Invoke(this, new EventArgs());
        }



        void CheckGameOver()
        {
            if (humanHp > 0 && computerHp > 0) isGameOver = false;
            else isGameOver = true;
            GameFinished?.Invoke(this, new EventArgs());
        }
    }
}
