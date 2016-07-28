using System;

namespace InputRedirectionNTR
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        public static NTRClient ntrClient;
        public static ScriptHelper scriptHelper;
        public static Boolean Connected = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ntrClient = new NTRClient();
            scriptHelper = new ScriptHelper();

            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
