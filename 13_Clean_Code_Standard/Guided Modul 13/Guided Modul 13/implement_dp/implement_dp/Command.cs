

namespace command_dp
{
    public interface ICommand
    {
        void Execute();
    }

    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("TV menyala");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV dimatikan");
        }
    }

    public class TelevisionTurnOn : ICommand
    {
        private readonly Television _television;

        public TelevisionTurnOn(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOn();
        }
    }

    public class TelevisionTurnOff : ICommand
    {
        private readonly Television _television;

        public TelevisionTurnOff(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOff();
        }
    }

    public class RemoteTV
    {
        private ICommand? _turnOn;
        private ICommand? _turnOff;

        public void SetTurnOn(ICommand command)
        {
            _turnOn = command;
        }

        public void SetTurnOff(ICommand command)
        {
            _turnOff = command;
        }

        public void TurnOnTV()
        {
            _turnOn?.Execute();
        }

        public void TurnOffTV()
        {
            _turnOff?.Execute();
        }
    }
}
