using System;
using System.Collections.Generic;
using System.IO;
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

namespace Notepad_
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class Notepad : Window
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter sw = File.CreateText($@"{filePath}\{Filename.Text}.txt"))
            {
                sw.WriteLine(Note.Text);
            }

            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
