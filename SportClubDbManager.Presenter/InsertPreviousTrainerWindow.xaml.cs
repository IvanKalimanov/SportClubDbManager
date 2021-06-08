using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SportClubDbManager.Presenter
{
    /// <summary>
    /// Логика взаимодействия для InsertPreviousTrainerWindow.xaml
    /// </summary>
    public partial class InsertPreviousTrainerWindow : Window
    {
        private readonly ITrainerService _trainerService;
        private readonly ISportsmanService _sportsmanService;
        private readonly IPreviousTrainerService _previousTrainerService;

        public InsertPreviousTrainerWindow(IPreviousTrainerService previousTrainerService, ITrainerService trainerService, ISportsmanService sportsmanService)
        {
            _trainerService = trainerService;
            _sportsmanService = sportsmanService;
            _previousTrainerService = previousTrainerService;
            InitializeComponent();
            Loaded += InsertPreviousTrainerWindow_Loaded;
        }
        private async void InsertPreviousTrainerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var trainers = await _trainerService.GetAll();
            TrainerComboBox.ItemsSource = trainers.Select(x => x.Fio + "(id: " + x.Id + ")");
            var sportsmen = await _sportsmanService.GetAll();
            SportsmanComboBox.ItemsSource = sportsmen.Select(x => x.Fio + "(certNum: " + x.CertNum + ")");
        }
        private async void insertButton_Click(object sender, RoutedEventArgs e)
        {
            string trainerInfo = TrainerComboBox.Text;
            decimal.TryParse(trainerInfo[(trainerInfo.LastIndexOf("(id: ") + 5)..(trainerInfo.Length-1)], out decimal trainerId);

            string sportsmanInfo = SportsmanComboBox.Text;
            decimal.TryParse(sportsmanInfo[(sportsmanInfo.LastIndexOf("(certNum: ") + 10)..(sportsmanInfo.Length - 1)], out decimal sportsmanCertNum);

            DateTime endDate = (DateTime)PreviousTrainerEndDateDatePicker.SelectedDate;

            try
            {
                await _previousTrainerService.Insert(new PreviousTrainerDto()
                {
                    TrainerId = trainerId,
                    EndDate = endDate,
                    SportsmanCertNum = sportsmanCertNum
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            TrainerComboBox.Text = string.Empty;
            PreviousTrainerEndDateDatePicker.SelectedDate = null;
            SportsmanComboBox.Text = string.Empty;
        }
        private void DecimalTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(char.IsDigit(e.Text, 0) || (e.Text == ".")))
            {
                e.Handled = true;
            }
        }

        private void IntegerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val) && e.Text != "-")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void DecimalTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true; // если пробел, отклоняем ввод
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SportsmanPartnerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
