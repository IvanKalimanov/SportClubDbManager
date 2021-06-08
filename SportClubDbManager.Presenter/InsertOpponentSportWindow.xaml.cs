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
    public partial class InsertOpponentSportWindow : Window
    {
        private readonly IOpponentSportService _opponentSportService;

        public InsertOpponentSportWindow(IOpponentSportService opponentSportService)
        {
            _opponentSportService = opponentSportService;
            InitializeComponent();
        }

        private async void insertButton_Click(object sender, RoutedEventArgs e)
        {
            string name = OpponentSportNameTextBox.Text;
            string type = OpponentSportTypeComboBox.Text;
            try
            {
                await _opponentSportService.Insert(new Core.DTO.OpponentSportDto() { Name = name, Type = type });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            OpponentSportNameTextBox.Text = string.Empty;

            OpponentSportTypeComboBox.Text = string.Empty;
        }
    }
}
