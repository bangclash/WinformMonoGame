using System;

namespace WinformMonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Form1 form = new Form1();
            form.Show();
            using (var game = new Game1(form.GetDrawSurface()))
            {
                form.SetGameObject(game);
                game.Run();
            }
        }
    }
}
