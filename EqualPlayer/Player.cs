namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass { get;}
        public string Name { get; }
        public Player (PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /* public override bool Equals(object obj)
        {
            return
        } */
    }
}