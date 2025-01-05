namespace Vektorel.BasicControls
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmSmallGame());
        }
    }
}