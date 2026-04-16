using System.Windows;

namespace IspoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {
            StudentsWindow studentsWindow = new StudentsWindow();
            studentsWindow.Show();
            this.Close();
        }

        private void btnGroups_Click(object sender, RoutedEventArgs e)
        {
            GroupsWindow groupsWindow = new GroupsWindow();
            groupsWindow.Show();
            this.Close();
        }

        private void btnTeachers_Click(object sender, RoutedEventArgs e)
        {
            TeachersWindow teachersWindow = new TeachersWindow();
            teachersWindow.Show();
            this.Close();
        }

        private void btnDisciplines_Click(object sender, RoutedEventArgs e)
        {
            DisciplinesWindow disciplinesWindow = new DisciplinesWindow();
            disciplinesWindow.Show();
            this.Close();
        }
    }
}