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
using Microsoft.Win32;
using System.IO;

namespace MyNoteApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentFileName { get; set; }

        public bool TextChanged { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            currentFileName = String.Empty;
            TextChanged = false;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (currentFileName == String.Empty) //if the filename is empty... prompt the save dialog box to save as a new name and .txt extension
            {
                sfd.FileName = "New Note";
                sfd.DefaultExt = ".txt";
                sfd.Filter = "Text files (*.txt) | *.txt";
            }
            else
            {
                sfd.FileName = currentFileName;
            }
            bool? result = sfd.ShowDialog();
            if (result == true)
            {
                File.WriteAllText(sfd.FileName, Editor.Text);
                MessageBox.Show("Your file has been saved");
            }
            else
            {
                MessageBox.Show("Your file has not been saved");
                return;
            }
        }

        private void load_Click(object sender, RoutedEventArgs e) //on click
        {
            OpenFileDialog ofd = new OpenFileDialog(); //instantiating a new object
            ofd.Filter = "Text files (*.txt) | *.txt"; //to filter showing text files in the dialog box only
            bool? result = ofd.ShowDialog(); //invoking the method that will return the user's selection
            if (result == true) //if true that a file is selected
            {
                string fileName = ofd.FileName; //assign user's selected file to to filename
                string input = File.ReadAllText(fileName); //assign all text in (filename) to input
                Editor.Text = input; //reads the text in filename to the editor.text box in the UI
                currentFileName = ofd.FileName;
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Would you like to save your file?", "Changes", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                //Delete all text in Editor
                Editor.Text = String.Empty;
                currentFileName = String.Empty;
            }
            else 
            { 
                save_Click(this, new RoutedEventArgs());
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            if (TextChanged)
            {
                MessageBoxResult result = MessageBox.Show("Would you like to save your file?", "Changes", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    save_Click(this, new RoutedEventArgs());
                }
                else
                {
                    Application.Current.Shutdown();
                }
            }
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChanged = true;
        }
    }
}
