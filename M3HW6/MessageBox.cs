using System;

namespace M3HW6
{
    public class MessageBox
    {
        public event Action<State> CloseWindowHandler;

        public async void Open()
        {
            Task.Run(() =>
            {
                Console.WriteLine("The window is opened");

                Task.Delay(3000).GetAwaiter().GetResult();

                Console.WriteLine("The window is closed");

                Array states = Enum.GetValues(typeof(State));

                var randomState = (State)states.GetValue(new Random().Next(states.Length));

                CloseWindowHandler(randomState);
            }).GetAwaiter().GetResult();
        }
    }
}
