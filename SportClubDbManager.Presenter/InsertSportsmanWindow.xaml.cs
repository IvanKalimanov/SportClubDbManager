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
    public partial class InsertSportsmanWindow : Window
    {
        private readonly ITrainerService _trainerService;
        private readonly ISportsmanService _sportsmanService;

        public InsertSportsmanWindow(ITrainerService trainerService, ISportsmanService sportsmanService)
        {
            _trainerService = trainerService;
            _sportsmanService = sportsmanService;
            InitializeComponent();
            Loaded += InsertTrainerWindow_Loaded;
        }
        private async void InsertTrainerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var trainers = await _trainerService.GetAll();
            SportsmanTrainerComboBox.ItemsSource = trainers.Select(x => x.Fio + "(id: " + x.Id + ")");
            var sportsmen = await _sportsmanService.GetAll();
            SportsmanPartnerComboBox.ItemsSource = sportsmen.Select(x => x.Fio + "(certNum: " + x.CertNum + ")");
        }
        private async void insertButton_Click(object sender, RoutedEventArgs e)
        {
            string fio = SportsmanFIOTextBox.Text;
            decimal.TryParse(SportsmanCertNumTextBox.Text, out decimal certNum);
            decimal.TryParse(SportsmanRatingTextBox.Text, NumberStyles.Any, new CultureInfo("en-US"), out decimal rating);
            string level = SportsmanLevelTextBox.Text;

            string trainerInfo = SportsmanTrainerComboBox.Text;
            decimal.TryParse(trainerInfo[(trainerInfo.LastIndexOf("(id: ") + 5)..(trainerInfo.Length-1)], out decimal trainerId);

            string partnerInfo = SportsmanPartnerComboBox.Text;
            decimal.TryParse(partnerInfo[(partnerInfo.LastIndexOf("(certNum: ") + 10)..(partnerInfo.Length - 1)], out decimal partnerCertNum);

            DateTime birthDate = (DateTime)SportsmanBirhtDateDatePicker.SelectedDate;
            DateTime? startDate = SportsmanStartDateDatePicker.SelectedDate;
            char sex = SportsmanSexComboBox.Text[0];
            string address = SportsmanAddressTextBox.Text;
            string mobilePhone = SportsmanMobilePhoneTextBox.Text;
            string homePhone = SportsmanHomePhoneTextBox.Text;
            try
            {
                await _sportsmanService.Insert(new SportsmanDto()
                {
                    CertNum = certNum,
                    Fio = fio,
                    Level = level,
                    Rating = rating,
                    TrainerId = trainerId,
                    BirthDate = birthDate,
                    StartDate = startDate,
                    MobilePhone = mobilePhone,
                    HomePhone = homePhone,
                    Sex = sex,
                    Address = address,
                    PartnerCertNum = partnerCertNum
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            SportsmanFIOTextBox.Text = string.Empty;
            SportsmanCertNumTextBox.Text = string.Empty;
            SportsmanRatingTextBox.Text = string.Empty;
            SportsmanTrainerComboBox.Text = string.Empty;
            SportsmanLevelTextBox.Text = string.Empty;
            SportsmanAddressTextBox.Text = string.Empty;
            SportsmanBirhtDateDatePicker.SelectedDate = null;
            SportsmanStartDateDatePicker.SelectedDate = null;
            SportsmanSexComboBox.Text = string.Empty;
            SportsmanPartnerComboBox.Text = string.Empty;
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
