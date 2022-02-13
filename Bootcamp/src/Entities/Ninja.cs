namespace Bootcamp.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, string HeroClass, int HealthPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }
        public override string Attack() {
            return this.Name + " " + "jogou uma shuriken envenenada!";
        }
    }
}