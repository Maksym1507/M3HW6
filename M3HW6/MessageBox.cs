using System;

namespace M3HW6
{
    public class MessageBox
    {
        public event Action<State> CloseWindowHandler;

        public async void Open()
        {
            Console.WriteLine("The window is opened");

            await Task.Delay(3000);

            Console.WriteLine("The window is closed");

            CloseWindowHandler((State)new Random().Next(0, 2));
        }
    }
}
