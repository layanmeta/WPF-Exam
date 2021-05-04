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

namespace WPFexam2
{
    /// <summary>
    /// Interaction logic for QuestionControl.xaml
    /// </summary>
    public partial class QuestionControl : UserControl
    {
        private Button _correctButton;
        private bool _isTimerStopped = false;

        public QuestionControl()
        {
            InitializeComponent();

            CreateQuestion("5 + 5", "12", "17", "10", "7", 3);
            StartCountdown();
        }

        public void CreateQuestion(string question, string answerOne, string answerTwo, string answerThree, string answerFour, int correctAnswer)
        {
            questionlabel.Content = question;
            question1button.Content = answerOne;
            question2button.Content = answerTwo;
            question3button.Content = answerThree;
            question4button.Content = answerFour;

            if (correctAnswer == 1) _correctButton = question1button;
            if (correctAnswer == 2) _correctButton = question2button;
            if (correctAnswer == 3) _correctButton = question3button;
            if (correctAnswer == 4) _correctButton = question4button;
        }

        public async void StartCountdown()
        {
            for (var i = 30; i >= 0; i--)
            {
                await Task.Delay(1000);
                if (_isTimerStopped == true)
                {
                    return;
                }
                Timer.Content = i;

                if (i >= 15)
                {
                    Timer.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                }
                else
                {
                    Timer.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                }
            }
            DisableButtons();
            grid.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));

        }

        public void StopCountdown()
        {
            _isTimerStopped = true;
        }

        public void DisableButtons()
        {
            question1button.IsEnabled = false;
            question2button.IsEnabled = false;
            question3button.IsEnabled = false;
            question4button.IsEnabled = false;
        }

        private void QuestionButton_Click(object sender, RoutedEventArgs e)
        {
            if (_correctButton == sender)
            {
                StopCountdown();
                DisableButtons();
                grid.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else
            {
                StopCountdown();
                DisableButtons();
                grid.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }          
        }
    }
}
