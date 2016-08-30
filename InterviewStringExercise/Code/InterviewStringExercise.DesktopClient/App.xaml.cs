using InterviewStringExercise.DesktopClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace InterviewStringExercise.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var window = new MainWindow
                        {
                            DataContext = new StringConvertViewModel()
                        };
            window.ShowDialog();//Create and display a MainWindow that's linked to StringCovertViewModel object
        }
    }
}
