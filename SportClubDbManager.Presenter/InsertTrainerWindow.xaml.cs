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
    /// Логика взаимодействия для InsertTrainerWindow.xaml
    /// </summary>
    public partial class InsertTrainerWindow : Window
    {
        private readonly ITrainerService _trainerService;
        private readonly ISportService _sportService;

        public InsertTrainerWindow(ITrainerService trainerService, ISportService sportService)
        {
            _trainerService = trainerService;
            _sportService = sportService;
            InitializeComponent();
            Loaded += InsertTrainerWindow_Loaded;
        }
        private async void InsertTrainerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var sports = await _sportService.GetAll();
            TrainerSportComboBox.ItemsSource = sports.Select(x => x.Name);
        }
        private async void insertButton_Click(object sender, RoutedEventArgs e)
        {
            string fio = TrainerFIOTextBox.Text;
            decimal.TryParse(TrainerIdTextBox.Text, out decimal id);
            decimal.TryParse(TrainerRatingTextBox.Text, NumberStyles.Any, new CultureInfo("en-US"), out decimal rating);
            string level = TrainerLevelTextBox.Text;
            string sportName = TrainerSportComboBox.Text;
            try
            {
                await _trainerService.Insert(new TrainerDto() 
                    {
                        Id = id, 
                        Fio = fio, 
                        Level = level,
                        Rating = rating,
                        SportName = sportName,
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            TrainerFIOTextBox.Text = string.Empty;
            TrainerIdTextBox.Text = string.Empty;
            TrainerRatingTextBox.Text = string.Empty;
            TrainerSportComboBox.Text = string.Empty;
            TrainerLevelTextBox.Text = string.Empty;
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
