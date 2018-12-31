using System;
using System.Windows;
using LeagueManager.ViewModels;
using LeagueManager.Views;
using static System.String;

namespace LeagueManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly MainWindowViewModel _code = new MainWindowViewModel();
        public static string PlayerName;

        public MainWindow()
        {
            InitializeComponent();
            LeagueList.ItemsSource = _code.Refresh();
            PlayerList.ItemsSource = _code.RefreshPlayers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _code.CreateLeague();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            LeagueList.ItemsSource = _code.Refresh();
            PlayerList.ItemsSource = _code.RefreshPlayers();
        }

        private void leagueDelete_Click(object sender, RoutedEventArgs e)
        {

            if (LeagueList.Text != Empty)
            {
                _code.DeleteLeague(LeagueList.Text);
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void loadLeague_Click(object sender, RoutedEventArgs e)
        {
            if (LeagueList.Text != Empty)
            {
                _code.LoadLeague(LeagueList.Text);
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _code.PlayerCreator();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (PlayerList.Text != Empty)
            {
                _code.DeletePlayer(PlayerList.Text);
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            _code.ClearAll();
            MessageBox.Show("Done");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            PlayerName = PlayerList.Text;
            PlayerEditor ed = new PlayerEditor();
            ed.Show();
        }
    }
}
