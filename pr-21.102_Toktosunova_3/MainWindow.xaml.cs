using System;
using System.Collections.Generic;
using System.Data.Entity;
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


namespace pr_21._102_Toktosunova_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DbContext dbContext;

        public MainWindow()
        {
            InitializeComponent();

            // контекст бд с использованием строки подключения
            string connectionString = "data source=DESKTOPCHIK\\SQLEXPRESS;initial catalog=RK-pr-21.102-19;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
            dbContext = new DbContext(connectionString);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = searchTB.Text.Trim();

            var query = dbContext.Discipline.Where(d => d.Name.Contains(searchQuery))
                                             .OrderByDescending(d => d.Name)
                                             .ThenBy(d => d.Name)
                                             .ToList();

            if (!query.Any())
            {
                MessageBox.Show("Результаты поиска отсутствуют.", "Поиск",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                LoadData.ItemsSource = query;
            }
        }

        private void LoadData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

   
   
}

