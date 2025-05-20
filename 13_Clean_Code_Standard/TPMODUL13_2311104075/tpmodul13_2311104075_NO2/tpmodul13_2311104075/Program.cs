// File: Program.cs  
namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            NewsPublisher publisher = new NewsPublisher();
            User user1 = new User("Alice");
            User user2 = new User("Bob");

            publisher.Attach(user1);
            publisher.Attach(user2);

            publisher.PublishNews("Presiden mengumumkan kebijakan baru!");
        }
    }
}