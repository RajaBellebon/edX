﻿
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


namespace Mod11_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayList students = new ArrayList();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.City = txtCity.Text;
            // Use a lambda expression to pass the student object in the collection keepin UI responsive
            Task task1 =new Task(() =>AddToCollection(newStudent));
            task1.Start();
            
            ClearForm();

            
        }

        
        private void AddToCollection(Student student)
        {
            // This line of code is intended to simulate network or database latency
            // It causes a non-responsive UI
            // Do not remove this line of code as a way of completing the assignment
            // You MUST use a C# task to get credit
            Thread.Sleep(5000);           
            students.Add(student);
            int count = students.Count;
            MessageBox.Show("Student created successfully.  Collection contains " + count.ToString() + " Student(s).");
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtFirstName.Focus();
        }

    }
}
