namespace Entregar.SRC.Entities
{
    public abstract class Hero 
    {
        public  Hero(string Name, int Level, string Herotype,int HealthPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.HealthPoint = HealthPoint;
            this.MagicPoint= MagicPoint;
        }


        public string Name;

        public int Level;

        public string Herotype;

        public int HealthPoint;

        public int MagicPoint;


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Herotype +this.HealthPoint+" "+ this.MagicPoint;

        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada ";
        }

        public string Perfil()
        {
            return  this.Name + " " + this.Level + " " + this.Herotype +this.HealthPoint+" "+ this.MagicPoint;
        }
    }
}