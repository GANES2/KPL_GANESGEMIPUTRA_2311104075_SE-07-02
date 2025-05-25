
using singleton_dp;
using adapter_dp;
using command_dp;


namespace desaign_pattern
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("=========================== Singleton ======================");
            Rektor rektor1 = Rektor.GetRektor();
            Rektor rektor2 = Rektor.GetRektor();

            if (rektor1 == rektor2)
            {
                Console.WriteLine("Rektor sama");
            }
            else
            {
                Console.WriteLine("Rektor berbeda");
            }

            rektor1.Tandatangan();

            Console.WriteLine("========================== Adapter ==========================");

            IndonesianPlug indonesianPlug = new IndonesianPlug();
            IAmericanPlug adaptor = new PlugAdaptor(indonesianPlug);
            adaptor.Plugin();

            Console.WriteLine("========================== Command ==========================");

            RemoteTV remote = new RemoteTV();
            Television tv = new Television();

            ICommand turnOn = new TelevisionTurnOn(tv);
            ICommand turnOff = new TelevisionTurnOff(tv);

            remote.SetTurnOn(turnOn);
            remote.SetTurnOff(turnOff);
            remote.TurnOnTV();
            remote.TurnOffTV();

            Console.ReadLine();
        }
    }
}
