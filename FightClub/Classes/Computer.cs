using System;
namespace FightClub
{
    class Computer : Player, IPlayer
    {
        // ctor
        public Computer(string name = "Computer", int hp = 100) : base(name, hp) { }
       
        public BodyPart BlockBodyPart { get; private set; }
        public BodyPart HitEnemyBodyPart { get; private set; }

        public event Played Played;

        Random rnd = new Random();
        public void Play()
        {
            BodyPart randomBodyPart = (BodyPart)rnd.Next(Enum.GetNames(typeof(BodyPart)).Length);
            HitEnemyBodyPart = BlockBodyPart = randomBodyPart;
            Played?.Invoke(this, BlockBodyPart);
        }
    }
}
