using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace SportClubDbManager.Presenter
{
    /// <summary>
    /// Логика взаимодействия для UpdateSportWindow.xaml
    /// </summary>
    public partial class UpdateOpponentSportWindow : Window
    {
        private readonly IOpponentSportService _opponentSportService;
        private OpponentSportDto _opponentSportDto;

        public UpdateOpponentSportWindow(IOpponentSportService sportService, ref OpponentSportDto item)
        {
            InitializeComponent();
            _opponentSportDto = item;
            sportNameTextBox.Text = item.Name;
            sportTypeComboBox.Text =  item.Type;
            _opponentSportService = sportService;
        }


        private void sportNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _opponentSportDto.Type = sportTypeComboBox.Text;
            if (await _opponentSportService.Update(_opponentSportDto))
            {
                MessageBox.Show("Строка обновлена!");
            }
        }
    }
}
