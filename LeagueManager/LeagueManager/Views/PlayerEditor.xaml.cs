using System.Windows;
using LeagueManager.ViewModels;

namespace LeagueManager.Views
{
    /// <summary>
    /// Interaction logic for PlayerEditor.xaml
    /// </summary>
    public partial class PlayerEditor
    {
        private readonly PlayerEditorViewModel _vm = new PlayerEditorViewModel();

        public PlayerEditor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _vm.Edit(MainWindow.PlayerName, NameBox.Text, EloBox.Text);
            Close();
        }
    }
}
