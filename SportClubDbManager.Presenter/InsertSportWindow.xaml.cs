using SportClubDbManager.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для InsertSportWindow.xaml
    /// </summary>
    public partial class InsertSportWindow : Window
    {
        private readonly ISportService _sportService;

        public InsertSportWindow(ISportService sportService)
        {
            _sportService = sportService;
            InitializeComponent();
        }

        private async void insertButton_Click(object sender, RoutedEventArgs e)
        {
            string name = sportNameTextBox.Text;
            string type = sportTypeComboBox.Text;
            try
            {
                await _sportService.Insert(new Core.DTO.SportDto() { Name = name, Type = type });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            sportNameTextBox.Text = string.Empty;
            sportTypeComboBox.Text = string.Empty;
        }
    }
}
