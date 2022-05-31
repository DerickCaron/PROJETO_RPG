namespace RPG_PROJETO.src.Entity
{
    public class Gladiator : Hero
    {
        public Gladiator(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
          
          public override string attack(){
            return this.Name + " Golpeia com a espada ";
        }

        public string attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " Golpeia com a espada com alto bonus de ataque de " + Bonus + " ponto(s)";
            }else{
                return this.Name + " Golpeia com a espada com pouco bonus de " + Bonus + " ponto(s)";
            }

        }
    }
}