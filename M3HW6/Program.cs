namespace M3HW6
{
    internal class Program
    {
        private static async Task Main()
        {
            var messageBox = new MessageBox();

            var tcs = new TaskCompletionSource<State>();

            messageBox.CloseWindowHandler += (state) =>
            {
                if (state == State.Ok)
                {
                    Console.WriteLine("Operation was confirmed");
                }

                if (state == State.Cancel)
                {
                    Console.WriteLine("Operation was rejected");
                }

                tcs.SetResult(state);
            };

            messageBox.Open();

            await tcs.Task;
        }
    }
}