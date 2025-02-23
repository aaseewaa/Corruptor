 internal class Program
    {
        static void Main(string[] args)
        {
            Simulator sim = new Simulator(1000000, 3650);
            sim.RunSimmulation();
        }
        static void Result(Simulator simulator)
        {
            System.Console.WriteLine(($"все дни" {simulator.MaxDays}));
        }
    }