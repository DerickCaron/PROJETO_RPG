namespace RPG_PROJETO.src.Entity
{
    public class Wizard:Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string attack(){
            return this.Name + " Lançou magia";
        }

        
    public string attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " lançou magia com alto bonus de ataque de " + Bonus + " ponto(s)";
            }else{
                return this.Name + " lançou magia com pouco bonus de " + Bonus + " ponto(s)";
            }
        }

    }
}