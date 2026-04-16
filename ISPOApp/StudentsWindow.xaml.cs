using ISPOApp;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace IspoApp
{
    public partial class StudentsWindow : Window
    {
        public StudentsWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                using (var db = new ИСПОEntities())
                {
                    var students = await db.students
                        .Include(s => s.groups)
                        .ToListAsync();
                    dgStudents.ItemsSource = students;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}