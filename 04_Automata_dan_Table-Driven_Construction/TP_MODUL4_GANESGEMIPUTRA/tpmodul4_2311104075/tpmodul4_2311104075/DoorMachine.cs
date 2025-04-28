public class DoorMachine
{
    private string state = "Terkunci";

    public void Kunci()
    {
        state = "Terkunci";
        Console.WriteLine("Pintu terkunci");
    }

    public void Buka()
    {
        state = "Terbuka";
        Console.WriteLine("Pintu tidak terkunci");
    }

    public string GetState()
    {
        return state;
    }
}
