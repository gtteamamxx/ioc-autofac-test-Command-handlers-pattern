using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Command;
using WpfApp1.Command.Something;
using WpfApp1.Modules;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static IContainer _container;

        public MainWindow()
        {
            InitializeComponent();
            BuildIoC();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _container.Resolve<ICommandDispatcher>()
                .Dispatch(new SomethingCommand()
                {
                    Name = "teskt"
                });
        }

        private void BuildIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<CommandModule>();
            _container = builder.Build();
        }
    }
}
