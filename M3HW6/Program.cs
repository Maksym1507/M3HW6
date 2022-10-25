namespace M3HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var messageBox = new MessageBox();

            messageBox.CloseWindowHandler += (State state) =>
            {
                if (state == State.Ok)
                {
                    Console.WriteLine("Operation was confirmed");
                }

                if (state == State.Cancel)
                {
                    Console.WriteLine("Operation was rejected");
                }
            };

            messageBox.Open();
        }
    }
}