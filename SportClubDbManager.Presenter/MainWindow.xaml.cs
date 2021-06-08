using SportClubDbManager.Core.DTO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISportService _sportService;
        private readonly IOpponentSportService _opponentSportService;
        private readonly ISportsmanService _sportsmanService;
        private readonly ITrainerService _trainerService;
        private readonly IPreviousTrainerService _previousTrainerService;
        private readonly IReportService _reportService;

        public MainWindow(ISportService sportService, IOpponentSportService opponentSportService, ISportsmanService sportsmanService, ITrainerService trainerService, IPreviousTrainerService previousTrainerService, IReportService reportService)
        {
            _sportService = sportService;
            _opponentSportService = opponentSportService;
            _sportsmanService = sportsmanService;
            _trainerService = trainerService;
            _previousTrainerService = previousTrainerService;
            _reportService = reportService;
            InitializeComponent();
        }

        private void SportInsertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertSportWindow insertSportWindow = new InsertSportWindow(_sportService)
            {
                Owner = this
            };
            insertSportWindow.ShowDialog();
        }
        private async void RefreshTable()
        {
            if (SportTabItem != null && SportTabItem.IsSelected)
            {
                Table.ItemsSource = await _sportService.GetAll();
            }
            if (SportsmenTabItem != null && SportsmenTabItem.IsSelected)
            {
                Table.ItemsSource = await _sportsmanService.GetAll();
            }
            if (TrainersTabItem != null && TrainersTabItem.IsSelected)
            {
                Table.ItemsSource = await _trainerService.GetAll();
            }
            if (OpponentSportTabItem != null && OpponentSportTabItem.IsSelected)
            {
                Table.ItemsSource = await _opponentSportService.GetAll();
            }
            if (PreviousTrainerTabItem != null && PreviousTrainerTabItem.IsSelected)
            {
                Table.ItemsSource = await _previousTrainerService.GetAll();
            }
        }
        private void ButtonsTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshTable();
        }

        private bool IsOneItemSelected()
        {
            var selectedItems = Table.SelectedItems;
            return selectedItems.Count == 1;
        }

        private bool IsItemsSelected()
        {
            var selectedItems = Table.SelectedItems;
            return selectedItems.Count > 0;
        }
        private void UpdateSportButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsOneItemSelected())
            {
                MessageBox.Show("Выберите одну строку для изменения!");
                return;
            }
            SportDto item = Table.SelectedItem as SportDto;
            UpdateSportWindow updateSportWindow = new UpdateSportWindow(_sportService, ref item)
            {
                Owner = this
            };
            updateSportWindow.ShowDialog();
            RefreshTable();
        }

        private async void DeleteSportButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsItemsSelected())
            {
                MessageBox.Show("Выберите строки для удаления");
                return;
            }
            var selectedItems = Table.SelectedItems;
            foreach (var item in selectedItems)
            {
                SportDto sportDto = item as SportDto;
                await _sportService.Delete(sportDto.Name);
            }
            RefreshTable();
        }

        private void OpponentSportInsertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertOpponentSportWindow insertOpponentSportWindow = new InsertOpponentSportWindow(_opponentSportService);
            insertOpponentSportWindow.Owner = this;
            insertOpponentSportWindow.ShowDialog();
            RefreshTable();
        }

        private async void DeleteOpponentSportButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsItemsSelected())
            {
                MessageBox.Show("Выберите строки для удаления");
                return;
            }
            var selectedItems = Table.SelectedItems;
            foreach (var item in selectedItems)
            {
                OpponentSportDto sportDto = item as OpponentSportDto;
                await _opponentSportService.Delete(sportDto.Name);
            }
            RefreshTable();
        }

        private void UpdateOpponentSportButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsOneItemSelected())
            {
                MessageBox.Show("Выберите одну строку для изменения!");
                return;
            }
            OpponentSportDto item = Table.SelectedItem as OpponentSportDto;
            UpdateOpponentSportWindow updateSportWindow = new UpdateOpponentSportWindow(_opponentSportService, ref item);
            updateSportWindow.Owner = this;
            updateSportWindow.ShowDialog();
            RefreshTable();

        }

        private void TrainerInsertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTrainerWindow insertTrainerWindow = new InsertTrainerWindow(_trainerService, _sportService);
            insertTrainerWindow.Owner = this;
            insertTrainerWindow.ShowDialog();
            RefreshTable();
        }

        private async void DeleteTrainerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsItemsSelected())
            {
                MessageBox.Show("Выберите строки для удаления");
                return;
            }
            var selectedItems = Table.SelectedItems;
            foreach (var item in selectedItems)
            {
                TrainerDto trainerDto = item as TrainerDto;
                await _trainerService.Delete(trainerDto.Id);
            }
            RefreshTable();
        }

        private void SportsmanInsertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertSportsmanWindow insertSportsmanWindow = new InsertSportsmanWindow(_trainerService, _sportsmanService)
            {
                Owner = this
            };
            insertSportsmanWindow.ShowDialog();
            RefreshTable();
        }

        private async void DeleteSportsmanButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsItemsSelected())
            {
                MessageBox.Show("Выберите строки для удаления");
                return;
            }
            var selectedItems = Table.SelectedItems;
            foreach (var item in selectedItems)
            {
                SportsmanDto sportsmanDto = item as SportsmanDto;
                await _sportsmanService.Delete(sportsmanDto.CertNum);
            }
            RefreshTable();
        }

        private void UpdateSportsmanButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsOneItemSelected())
            {
                MessageBox.Show("Выберите одну строку для изменения!");
                return;
            }
            SportsmanDto item = Table.SelectedItem as SportsmanDto;
            UpdateSportsmanWindow updateSportsmanWindow = new UpdateSportsmanWindow(_trainerService, _sportsmanService, ref item);
            updateSportsmanWindow.Owner = this;
            updateSportsmanWindow.ShowDialog();
            RefreshTable();
        }

        private void PreviousTrainerInsertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertPreviousTrainerWindow insertPreviousTrainerWindow = new InsertPreviousTrainerWindow(
                _previousTrainerService, _trainerService, _sportsmanService)
            {
                Owner = this
            };
            insertPreviousTrainerWindow.ShowDialog();
            RefreshTable();
        }

        private async void DeletePreviousTrainerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsItemsSelected())
            {
                MessageBox.Show("Выберите строки для удаления");
                return;
            }
            var selectedItems = Table.SelectedItems;
            foreach (var item in selectedItems)
            {
                PreviousTrainerDto previousTrainerDto = item as PreviousTrainerDto;
                await _previousTrainerService.Delete((decimal)previousTrainerDto.TrainerId, (decimal)previousTrainerDto.SportsmanCertNum);
            }
            RefreshTable();
        }

        private void SportsmenMovesReportMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow window = new ReportsWindow(_reportService, "SportsmenMoves")
            {
                Owner = this
            };
            window.ShowDialog();

        }
        private void SportsmenWithoutMovesReportMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow window = new ReportsWindow(_reportService, "SportsmenWithoutMoves")
            {
                Owner = this
            };
            window.ShowDialog();

        }

        private void PairedSportErrorReportMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow window = new ReportsWindow(_reportService, "PairedSportError")
            {
                Owner = this
            };
            window.ShowDialog();

        }
        
        private void OpponentSameSportReportMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow window = new ReportsWindow(_reportService, "OpponentSameSport")
            {
                Owner = this
            };
            window.ShowDialog();

        }

        private void SearchMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FindSportsmanWindow window = new FindSportsmanWindow(_trainerService, _sportsmanService)
            {
                Owner = this
            };
            window.ShowDialog();
        }
    }
}
