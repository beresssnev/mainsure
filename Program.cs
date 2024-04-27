namespace Minesweeper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new logWindow());
            Application.Run(new regWindow());
            
            Application.Run(new gameWindow());
            
            
        }

    }
}