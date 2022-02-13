namespace Bootcamp.src.Entities
{
    public class Hero
    {
        public Hero (string Name, int Level, string HeroClass, int HealthPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public Hero () {}

        public string Name;
        public int Level;
        public string HeroClass;
        public int HealthPoints;
        public int MagicPoints;

        public override string ToString() {
            return "Heroi: " + this.Name + " | " + "Level: " + this.Level + " | " + "Classe: " + this.HeroClass + " | " + "HP: " + this.HealthPoints + " | " + "MP: " + this.MagicPoints;
        }

        public virtual string Attack () {
            return this.Name + " " + "atacou usando sua espada!";
        } 
    }
}