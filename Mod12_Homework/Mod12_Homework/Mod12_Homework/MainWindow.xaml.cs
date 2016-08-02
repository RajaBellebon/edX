using System;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Mod12_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnWriteFile_Click(object sender, RoutedEventArgs e)
        {
           await WriteFileAsync();
        }

        private async  void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            await ReadFileAsync();
        }

        private async Task WriteFileAsync()
        {
            string filePath = @"SampleFile.txt";
            string text = txtContents.Text;

            await WriteTexAsync(filePath, text);
        }

         private async Task WriteTexAsync(string filePath, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);
           
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };
        }

        private async Task ReadFileAsync()
        {
            string filePath = @"SampleFile.txt";

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show(filePath + " not found", "File Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    string text = await ReadTextAsync(filePath);
                    txtContents.Text =  text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private async Task<string> ReadTextAsync(string filePath)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync:true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead =  await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

               return sb.ToString();
            }
        }
    }
}
