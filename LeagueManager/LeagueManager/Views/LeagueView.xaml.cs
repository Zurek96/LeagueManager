using System;
using System.Linq;
using System.Windows;
using LeagueManager.Context;
using LeagueManager.ViewModels;

namespace LeagueManager.Views
{
    /// <summary>
    /// Interaction logic for LeagueView.xaml
    /// </summary>
    public partial class LeagueView
    {
        private readonly LeagueViewerViewModel _viewer = new LeagueViewerViewModel();
        private readonly LeagueManagerContext _context = new LeagueManagerContext();

        public LeagueView()
        {
            InitializeComponent();
            ListView.ItemsSource = _viewer.InitializePlayers();
            AchListView.ItemsSource = _viewer.GetAchList();
            AchPlayers.ItemsSource = _viewer.RefreshPlayers(_context);
            AchDdl.ItemsSource = _viewer.GetAchNameList();
            MatchupsHistory.ItemsSource = _context.Turns.ToList();
            MatchupSelect.ItemsSource = _viewer.GetTurns();
            PlayerBoxList.ItemsSource = _viewer.RefreshPlayers(_context);
            GeneralStandings.ItemsSource = _viewer.ShowGeneralStandings();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            MatchupsListView.ItemsSource = _viewer.GenerateMatchups();
            MatchBox.ItemsSource = _viewer.Seed();
            MessageBox.Show("Done");
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (MatchBox.Text != String.Empty)
            {
                _viewer.DeleteMatchup(MatchBox.Text);
                MessageBox.Show("Matchup deleted!");
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MatchupsListView.ItemsSource = null;
            MatchupsListView.ItemsSource = _viewer.GetFilteredMatchups();
            MatchBox.ItemsSource = _viewer.Seed();
            AchListView.ItemsSource = _viewer.GetAchList();
            AchDdl.ItemsSource = _viewer.GetAchNameList();
        }

        private void Score_Click(object sender, RoutedEventArgs e)
        {
            if (MatchBox.Text != String.Empty)
            {
                
                _viewer.AddWinner(MatchBox.Text, WinnerBox.Text);
                MessageBox.Show("Winner added!");
                WinnerBox.Text = null;
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _viewer.Closing();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DailyStandings.ItemsSource = _viewer.ShowStandings();
        }

        private void SumUp_Click(object sender, RoutedEventArgs e)
        {
            DailyStandings.ItemsSource = _viewer.ShowStandings();
            GeneralStandings.ItemsSource = _viewer.ShowGeneralStandings();
            _viewer.CloseTurn();
        }

        private void Assign_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _viewer.Assign(AchDdl.Text, AchPlayers.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void AddAch_Click(object sender, RoutedEventArgs e)
        {
            _viewer.AchCreate();
        }

        private void DelAch_Click(object sender, RoutedEventArgs e)
        {
            _viewer.AchDelete(AchDdl.Text);
        }

        private void TurnInfo_Click(object sender, RoutedEventArgs e)
        {
            _viewer.TurnDetails(MatchupSelect.Text);
        }

        private void Absent_Click(object sender, RoutedEventArgs e)
        {
            _viewer.Absence(PlayerBoxList.Text);
            MessageBox.Show("Done");
        }

        private void Win_Click(object sender, RoutedEventArgs e)
        {
            WinnerBox.ItemsSource = _viewer.SeedWinner(MatchBox.Text);
        }
    }
}
