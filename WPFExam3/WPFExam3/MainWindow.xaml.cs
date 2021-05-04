using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFExam3
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();


            if (folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Filename.Text = folderDlg.SelectedPath;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            SearchItems();

        }

        private async Task SearchItems()
        {
            progressbar.Value = 0;
            var search = searchtextbox.Text;
            var files = Directory.GetFiles(Filename.Text);
            progressbar.Maximum = files.Count();

            new Task(() => {
                Parallel.ForEach(files, file =>
                {
                    if (file.Contains(search))
                    {
                        Dispatcher.Invoke(() =>
                        {
                            searchresultview.Items.Add(file);
                            progressbar.Value++;

                        });
                    }
                });
            }).Start();            
        }
    }
}
