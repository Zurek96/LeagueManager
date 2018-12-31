using System.Windows;
using LeagueManager.ViewModels;

namespace LeagueManager.Views
{
    /// <summary>
    /// Interaction logic for PlayerCreator.xaml
    /// </summary>
    public partial class PlayerCreator
    {
        private readonly PlayerCreatorViewModel _playerCreator = new PlayerCreatorViewModel();

        public PlayerCreator()
        {
            InitializeComponent();  
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            _playerCreator.AddPlayer(PlayerName.Text);
            Close();
        }
    }
}
