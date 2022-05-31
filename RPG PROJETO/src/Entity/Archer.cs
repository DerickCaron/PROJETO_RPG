namespace RPG_PROJETO.src.Entity
{
    public class Archer:Hero
    {
        public Archer(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
          
          public override string attack(){
            return this.Name + " Lançou flecha";
        }

        public string attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " lançou flecha com alto bonus de ataque de " + Bonus + " ponto(s)";
            }else{
                return this.Name + " lançou flecha com pouco bonus de " + Bonus + " ponto(s)";
            }

    }
    }
}