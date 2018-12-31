using System;
using System.Windows;
using LeagueManager.Context;
using LeagueManager.ViewModels;
using MessageBox = System.Windows.MessageBox;

namespace LeagueManager.Views
{
    /// <summary>
    /// Interaction logic for LeagueCreator.xaml
    /// </summary>
    public partial class LeagueCreator 
    {
        private readonly LeagueCreatorViewModel _creator = new LeagueCreatorViewModel();
        private readonly LeagueManagerContext _context = new LeagueManagerContext();

        public LeagueCreator()
        {
            InitializeComponent();
            PlayerCB.ItemsSource = _creator.RefreshPlayers(_context);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DateStart.SelectedDate != null) _creator.Submit((DateTime) DateStart.SelectedDate, LeagueName.Text);
            this.Close();
        }

        private void PlayerAdd_Click(object sender, RoutedEventArgs e)
        {
            _creator.PlayerAdd(PlayerCB.Text);
            MessageBox.Show("Done!");
        }
    }
}
