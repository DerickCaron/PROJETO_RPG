namespace RPG_PROJETO.src.Entity
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
          
          public override string attack(){
            return this.Name + " Lança shuriken";
        }

        public string attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " Lança shuriken com alto bonus de ataque de " + Bonus + " ponto(s)";
            }else{
                return this.Name + " Lança shuriken com pouco bonus de " + Bonus + " ponto(s)";
            }

    }
    }
}