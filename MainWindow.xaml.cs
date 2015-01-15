using System;
using System.Collections;
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

namespace studentRecords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        students myStudents;

        public MainWindow()
        {
            InitializeComponent();
            myStudents = new students();
            DataContext = myStudents.studentData;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            student newStudent = new student();

            newStudent.firstName = txtFirstName.Text;
            newStudent.grade = int.Parse(txtGrade.Text);

            myStudents.studentData.Add(newStudent);

            lblAverageGrade.Content = myStudents.studentData.Average(i => i.grade).ToString();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
           // lstStudents.ItemsSource=myStudents.studentData;
            lblAverageGrade.Content = myStudents.studentData.Average(i => i.grade).ToString();
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            myStudents.writeStudents();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }




    }
}
