namespace FightClub
{
    abstract class Player
    {
        // Properties
        public string Name { get; set; }
        public int Hp { get; set; }

        // ctor
        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
    }
}
