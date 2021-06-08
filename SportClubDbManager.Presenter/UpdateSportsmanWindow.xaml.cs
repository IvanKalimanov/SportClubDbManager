using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SportClubDbManager.Presenter
{
    /// <summary>
    /// Логика взаимодействия для InsertSportsmanWindow.xaml
    /// </summary>
    public partial class UpdateSportsmanWindow : Window
    {
        private readonly ITrainerService _trainerService;
        private readonly ISportsmanService _sportsmanService;
        private readonly SportsmanDto _sportsmanDto;

        public UpdateSportsmanWindow(ITrainerService trainerService, ISportsmanService sportsmanService, ref SportsmanDto item)
        {
            _trainerService = trainerService;
            _sportsmanService = sportsmanService;
            _sportsmanDto = item;
            InitializeComponent();
            Loaded += UpdateTrainerWindow_Loaded;
        }
        private async void UpdateTrainerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var trainers = await _trainerService.GetAll();
            SportsmanTrainerComboBox.ItemsSource = trainers.Select(x => x.Fio + "(id: " + x.Id + ")");
            var sportsmen = await _sportsmanService.GetAll();
            SportsmanPartnerComboBox.ItemsSource = sportsmen.Select(x => x.Fio + "(certNum: " + x.CertNum + ")");
            SportsmanFIOTextBox.Text = _sportsmanDto.Fio;
            SportsmanCertNumTextBox.Text = _sportsmanDto.CertNum.ToString();
            SportsmanRatingTextBox.Text = _sportsmanDto.Rating.ToString();
            SportsmanLevelTextBox.Text = _sportsmanDto.Level;
            SportsmanTrainerComboBox.Text = trainers.Where(x =>
            x.Id == _sportsmanDto.TrainerId).Select(x => x.Fio + "(id: " + x.Id + ")").First();
            SportsmanPartnerComboBox.Text = sportsmen.Where(x =>
            x.CertNum == _sportsmanDto.PartnerCertNum).Select(x => x.Fio + "(certNum: " + x.CertNum + ")").First();
            SportsmanBirhtDateDatePicker.SelectedDate = _sportsmanDto.BirthDate;
            SportsmanStartDateDatePicker.SelectedDate = _sportsmanDto.StartDate;
            SportsmanSexComboBox.Text = _sportsmanDto.Sex.ToString();
            SportsmanMobilePhoneTextBox.Text = _sportsmanDto.MobilePhone;
            SportsmanAddressTextBox.Text = _sportsmanDto.Address;
            SportsmanHomePhoneTextBox.Text = _sportsmanDto.HomePhone;
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            _sportsmanDto.Fio = SportsmanFIOTextBox.Text;
            decimal.TryParse(SportsmanCertNumTextBox.Text, out decimal certNum);
            _sportsmanDto.CertNum = certNum;
            decimal.TryParse(SportsmanRatingTextBox.Text, NumberStyles.Any, new CultureInfo("en-US"), out decimal rating);
            _sportsmanDto.Rating = rating;
            _sportsmanDto.Level = SportsmanLevelTextBox.Text;

            string trainerInfo = SportsmanTrainerComboBox.Text;
            decimal.TryParse(trainerInfo[(trainerInfo.LastIndexOf("(id: ") + 5)..(trainerInfo.Length-1)], out decimal trainerId);
            _sportsmanDto.TrainerId = trainerId;
            string partnerInfo = SportsmanPartnerComboBox.Text;
            decimal.TryParse(partnerInfo[(partnerInfo.LastIndexOf("(certNum: ") + 10)..(partnerInfo.Length - 1)], out decimal partnerCertNum);
            _sportsmanDto.PartnerCertNum = partnerCertNum;
            _sportsmanDto.BirthDate = (DateTime)SportsmanBirhtDateDatePicker.SelectedDate;
            _sportsmanDto.StartDate = SportsmanStartDateDatePicker.SelectedDate;
            _sportsmanDto.Sex = SportsmanSexComboBox.Text[0];
            _sportsmanDto.Address = SportsmanAddressTextBox.Text;
            _sportsmanDto.MobilePhone = SportsmanMobilePhoneTextBox.Text;
            _sportsmanDto.HomePhone = SportsmanHomePhoneTextBox.Text;
            try
            {
                await _sportsmanService.Update(_sportsmanDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

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
    }
}
