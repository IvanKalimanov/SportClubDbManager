using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Models;
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
    public partial class FindSportsmanWindow : Window
    {
        private readonly ITrainerService _trainerService;
        private readonly ISportsmanService _sportsmanService;

        public FindSportsmanWindow(ITrainerService trainerService, ISportsmanService sportsmanService)
        {
            _trainerService = trainerService;
            _sportsmanService = sportsmanService;
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string fio = SportsmanFIOTextBox.Text;
            string level = SportsmanLevelTextBox.Text;
            char? sex = null;

            DateTime? birthDate = SportsmanBirhtDateDatePicker.SelectedDate;
            DateTime? startDate = SportsmanStartDateDatePicker.SelectedDate;
            if(SportsmanSexComboBox.Text != string.Empty)
            {
                sex = SportsmanSexComboBox.Text[0];
            }

            string address = SportsmanAddressTextBox.Text;

            try
            {
                Table.ItemsSource = await _sportsmanService.SearchSportsmen(new SportsmanSearchModel()
                {
                    Fio = fio,
                    Level = level,
                    Address = address,
                    BirthDate = birthDate,
                    StartDate = startDate,
                    Sex = sex
                });
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
