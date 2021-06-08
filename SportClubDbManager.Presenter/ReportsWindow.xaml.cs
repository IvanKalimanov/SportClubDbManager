using SportClubDbManager.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ReportsWindow.xaml
    /// </summary>
    public partial class ReportsWindow : Window
    {
        private readonly IReportService _reportService;
        private readonly string _reportType;

        public ReportsWindow(IReportService reportService, string reportType)
        {
            _reportService = reportService;
            _reportType = reportType;
            InitializeComponent();
            Loaded += ReportWindow_Loaded;
        }

        private async void ReportWindow_Loaded(object sender, RoutedEventArgs e)
        {
            switch (_reportType)
            {
                case "SportsmenMoves":
                    ReportListBox.ItemsSource = await _reportService.GetSportsmenMovesReport();
                    break;

                case "SportsmenWithoutMoves":
                    ReportListBox.ItemsSource = await _reportService.GetSportsmenWithoutMovesReport();
                    break;

                case "PairedSportError":
                    ReportListBox.ItemsSource = await _reportService.GetPairedSportErrorReport();
                    break;

                case "OpponentSameSport":
                    ReportListBox.ItemsSource = await _reportService.GetOpponentSameSportReport();
                    break;

                default:
                    break;
            }


        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {
                dialog.PrintVisual(ReportListBox, _reportType);
            }
        }
    }
}
