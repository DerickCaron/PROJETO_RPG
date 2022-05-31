namespace RPG_PROJETO.src.Entity
{
   public class Hero
    {
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){

        }
       public string Name;
       public int Level;
       public string HeroType;  

        public override string ToString(){
            return "Nome: " + this.Name + "/ Level: " + this.Level + "/ HeroType: " + this.HeroType;
        }

        public virtual string attack(){
            return this.Name + " atacou com o super martelo";
        }



    }
}