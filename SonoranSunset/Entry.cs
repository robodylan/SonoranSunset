using System;

namespace SonoranSunset
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Entry
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game())
                game.Run();
        }
    }
}
