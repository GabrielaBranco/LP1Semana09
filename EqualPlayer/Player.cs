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
            return Name.GetHashCode() ^ PClass.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Player other = obj as Player;
            return this.Name.Equals(other.Name) && this.PClass.Equals(other.PClass);
        }
    }
}