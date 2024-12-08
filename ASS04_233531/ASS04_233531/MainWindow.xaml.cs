using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Windows;

namespace ASS02_233531
{
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Players { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Players = new ObservableCollection<string>(); 
            DataContext = this;
        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Players.Contains(playerName))
            {
                MessageBox.Show("Player already exists in the roster.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Players.Add(playerName); 
            PlayerNameTextBox.Clear(); 
            MessageBox.Show($"Player '{playerName}' added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (PlayersListBox.SelectedItem is string selectedPlayer)
            {
                Players.Remove(selectedPlayer); 
                MessageBox.Show($"Player '{selectedPlayer}' removed successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a player to remove.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
