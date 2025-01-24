using System.Windows;

namespace YoutubeViewers.WPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
