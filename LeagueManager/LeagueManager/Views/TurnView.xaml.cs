using System.Windows;
using LeagueManager.ViewModels;

namespace LeagueManager.Views
{
    /// <summary>
    /// Interaction logic for TurnView.xaml
    /// </summary>
    public partial class TurnView 
    {
        private readonly TurnViewModel _vm = new TurnViewModel();

        public TurnView()
        {
            InitializeComponent();
            TurnList.ItemsSource = _vm.ReadMatchups(LeagueViewerViewModel.TurnDate);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
