namespace FightClub
{
    class Human:Player, IPlayer
    {
        // ctor
        public Human(string name = "User", int hp = 100) : base(name, hp) { }

        public BodyPart BlockBodyPart { get; private set; }
        public BodyPart HitEnemyBodyPart { get; private set; }
        public event Played Played;
        private bool humanTurn = false;

        public void Play()
        {
            humanTurn = true;
        }

        public void UserAttack(BodyPart bodyPart)
        {
            if (humanTurn)
            {
                HitEnemyBodyPart = bodyPart;
                Played?.Invoke(this, bodyPart);
            }
        }

        public void UserProtect(BodyPart bodyPart)
        {
            if (humanTurn)
            {
                BlockBodyPart = bodyPart;
                Played?.Invoke(this, bodyPart);
            }
        }
    }
}
