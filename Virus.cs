abstract class Virus : IVirus
{
        protected string _code;
        protected bool _reinfection;
        protected float _infection;
        protected float _letality;

        #region Interface
        public string Code => _code;

        public bool Reinfection => _reinfection;

        public float Infection => _infection;

        public float Lethality => _letality;
        #endregion
        protected Virus(string code, bool reinfection, float infection, float letality)
        {
            _code = code;
            _reinfection = reinfection;
            _infection = infection;
            _letality = letality;
        }

        abstract public bool Death(Person person);
        abstract public bool Death(Person person)
        {
            if (rand.NextDouble()<=Lethality)
            {
                person.IsAlive = false;
                return true;
            }
            return false;
        }
    
        abstract public void Infect(Person person);
    
}
