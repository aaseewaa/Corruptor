interface IVirus
{
    string Code { get; }
    bool Reinfection { get; }
    float Lethality { get; }
    float Infection { get; }
    void Infect(Person person);
    bool Death(Person person);
}