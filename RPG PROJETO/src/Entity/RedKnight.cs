namespace RPG_PROJETO.src.Entity
{
    public class RedKnight:Hero
    {
        public RedKnight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
          
          public override string attack(){
            return this.Name + " Lançou lança";
        }

        public string attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " lançou lança com alto bonus de ataque de " + Bonus + " ponto(s)";
            }else{
                return this.Name + " lançou lança com pouco bonus de " + Bonus + " ponto(s)";
            }

    }
}
}