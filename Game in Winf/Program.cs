using System;

namespace MonoGameInWinform
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameForm form = new GameForm();
            Game1 game = new Game1(form.getDrawSurface());

            // By waiting with showing the form until all objects are created,
            // we can ensure all variables are initialized when MainForm.MainForm_Shown()
            // is run, and perform more setup there.
            // 
            form.Show();

            // ..and let the game begin! I mean editor.
            game.Run();


//            using (var game = new Game1())
  //              game.Run();
        }
    }
#endif
}
