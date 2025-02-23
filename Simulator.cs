class Simulator
{
    private const double _mortality = (double)16 / 1000;
        private const double _birthrate = (double)8 / 1000;

        private static Random _random = new Random();
        private List<Person> _alive;
        private List<Person> _dead;
        private List<Person> _illed;
        private int _maxDays;
        private int _days;
        public int MaxDays => _maxDays;
         public Simulator(int countPopulation, int maxDays)
        {
            _days = 0;
            _maxDays = maxDays;
            _alive = new List<Person>();
            _dead = new List<Person>();
            Population(countPopulation);
        }
       
         public void RunSimmulation()
        {
            for (int i = 0; i < 10; i++)
            {
                int index = _random.Next(_alive.Count);
                _illed.Add(_alive[index]);
            }

            for (int i = 0; i < _maxDays; i++)
            {
                _days = i;
                _alive.RemoveAll((p) =>
                {
                    p.UpdateAge();
                    if (p.Age>= 29200)
                    {
                        _dead.Add(p);
                        return true;
                    }
                    return false;
                });
                  Infection();
            }
            
        }
        public void Infection(Virus virus)
        {
            foreach( var person in _alive.ToList())
            {
                if(person.Status)
                {
                if (virus.Death(person))
                {
                    _alive.Remove(person);
                    _dead.Add(person)
                }
                }
            }
            foreach(var person in newIll)
            {
                _illed.Add(person);
                if (new Killar ("Virus", false, 0.1f, 0.05f).Death(person))
                {
                    _dead.Add(pepson);
                    _alive.Remove(person);
                } 
            }
        }
    
}