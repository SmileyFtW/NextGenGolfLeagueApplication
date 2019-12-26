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

    
    public partial class MainWindow : Window
    {
        IMainUIHandler MainUIHandler =new MainUIHandler();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddNewPlayer_Click(object sender,RoutedEventArgs e)
        {
            MainUIHandler.PlayerMgtHandler.AddNewPlayer();
            
            /*
            foreach (IPlayer player in MainUIHandler.PlayerMgtHandler.NewPlayers)
            {
                NewPlayers.Items.Add(player.PersonalInfo.NameOfPerson.FullName() + " - " + player.IDItem.ID);
            }
            */
        }
        private void UpdatePlayerInfo_Click(object sender, RoutedEventArgs e)
        {
        }
        private void UpdatePlayerListBox()
        {
        }
    }
}
