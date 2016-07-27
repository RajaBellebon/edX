using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Student> StudentListObject = new List<Student>();

        int pointeurStud = -1;

        // Show student info in the app window.
        private void showStudentInfo(Student s)
        {
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtCity.Text = s.City;
        }

        // Enable or disable next and previous buttons.
        private void updateButtons()
        {
            btnNext.IsEnabled = !(pointeurStud == (StudentListObject.Count - 1));
            btnPrevious.IsEnabled = !(pointeurStud <= 0);
        }
        //IEnumerable<object> StudentListObject1;
        public MainWindow()
        {
            InitializeComponent();

            // There are no students in the list at the beginning.
            btnNext.IsEnabled = false;
            btnPrevious.IsEnabled = false;
        }
        
        

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            // Create and add the new student to the list.
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;
            StudentListObject.Add(student);

            // Clear the contents of the text boxes.
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();


            // Update previous and next button
            updateButtons();

        }
       

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            pointeurStud--;
            showStudentInfo(StudentListObject[pointeurStud]);
            updateButtons();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pointeurStud++;
            showStudentInfo(StudentListObject[pointeurStud]);
            updateButtons();
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
