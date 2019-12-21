using GLA.Handlers.UI;
using GLA.Interfaces;
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

namespace GLA
{
    //The application will use a WPF interface when deployed

    /*
    public partial class MainWindow : Window
    {
        IMainUIHandler MainUIHandler;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            IMainUIHandler UIHandlerMain = new MainUIHandler();
        }
    }
    */

    // For now going to use a console interface to get started
    public class Program
    {
        public void Main(string[] args)
        {
            IMainUIHandler UIHandlerMain = new MainUIHandler();
            UIHandlerMain.PlayerMgtHandler.AddNewPlayer("2020", "_", 1, 3);
            foreach(IPlayer player in UIHandlerMain.PlayerMgtHandler.NewPlayers)
            {
                Console.WriteLine(player.ID.ToString());
                Console.WriteLine(player.PersonalInfo.NameOfPerson.FullName());
                Console.ReadLine();
            }
                
        }
    }
}
