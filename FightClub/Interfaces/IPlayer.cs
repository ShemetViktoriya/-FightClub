namespace FightClub
{
    enum BodyPart
    {
        Head, Torso, Legs
    }

    delegate void Played(object sender, BodyPart bodyPart);
    interface IPlayer
    {
        void Play();
        event Played Played;
        BodyPart BlockBodyPart { get; }
        BodyPart HitEnemyBodyPart { get; }
    }
}
