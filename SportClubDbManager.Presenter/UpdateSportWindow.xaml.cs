using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace SportClubDbManager.Presenter
{
    /// <summary>
    /// Логика взаимодействия для UpdateSportWindow.xaml
    /// </summary>
    public partial class UpdateSportWindow : Window
    {
        private readonly ISportService _sportService;
        private SportDto _sportDto;

        public UpdateSportWindow(ISportService sportService, ref SportDto item)
        {
            InitializeComponent();
            _sportDto = item;
            sportNameTextBox.Text = item.Name;
            sportTypeComboBox.Text =  item.Type;
            _sportService = sportService;
        }


        private void sportNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _sportDto.Type = sportTypeComboBox.Text;
            if (await _sportService.Update(_sportDto))
            {
                MessageBox.Show("Строка обновлена!");
            }
        }
    }
}
