namespace Entregar.SRC.Entities
{
    public class Wizard:Hero
    {

        public Wizard(string Name, int Level, string Herotype, int HealthPoint, int MagicPoint) : base(Name, Level, Herotype, HealthPoint, MagicPoint)
        {
            
        }


        public override string Attack()
        {
            return this.Name+ " lançou Magia ";
        }

        public string Attack(int Bonus)
        {
            if(Bonus> 6 ){
            return this.Name +" lançou Magia com bonus de ataque" + Bonus;
            }
            else{
                return this.Name+"lançou uma magia com bonus de " + Bonus;
            }
        }
    }
}