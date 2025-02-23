 internal class Killar : Virus
 {
     private static Random rand = new Random();
     public Killar(string code, bool reinfection, float infection,
         float letality) : base(code, reinfection, infection, letality)
     {
         _letality = letality+(float)rand.Next(-10, 10) / 100;
     }
     public override bool Death(Person person)
     {
         if(rand.NextDouble() <= Lethality)
             return true;
         return false;
     }

     public override void Infect(Person person)
     {
         if (person.Immunity <= Infection)
         {
             person.Status = true;
         }
     }
 }