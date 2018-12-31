using System;
using System.Windows;
using LeagueManager.ViewModels;

namespace LeagueManager.Views
{
    /// <summary>
    /// Interaction logic for AchievementCreator.xaml
    /// </summary>
    public partial class AchievementCreator 
    {
        AchievementCreatorViewModel creator = new AchievementCreatorViewModel();

        public AchievementCreator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            creator.AddPlayer(AchName.Text, Convert.ToInt32(AchScore.Text), AchDesc.Text);
            Close();
        }
    }
}
