using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace GameOfLife
{
    public partial class MainWindow : Window
    {
        private Grid mainGrid;
        DispatcherTimer timer;   //  Generation timer
        private int genCounter;
        private AdWindow[] adWindow;


        public MainWindow()
        {
            InitializeComponent();
            mainGrid = new Grid(MainCanvas);
            adWindow = new AdWindow[2];
            timer = new DispatcherTimer();
            timer.Tick += OnTimer;
            timer.Interval = TimeSpan.FromMilliseconds(100);
        }


        private void StartAd()
        {
            for (int i = 0; i < adWindow.Length; i++)
            {
                if (adWindow[i] == null)
                {
                    adWindow[i] = new AdWindow(this);
                    adWindow[i].Closed += AdWindowOnClosed;
                    adWindow[i].Top = this.Top + (330 * i) + 70;
                    adWindow[i].Left = this.Left + 240;
                    adWindow[i].Show();
                }
            }
        }

        private void AdWindowOnClosed(object sender, EventArgs eventArgs)
        {
            AdWindow closingWindow = (AdWindow)sender;

            for (int i = 0; i < adWindow.Length; i++)
            {
                if (adWindow[i] != null && adWindow[i].Uid.CompareTo(closingWindow.Uid) == 0)
                {
                    adWindow[i].Closed -= AdWindowOnClosed;
                    adWindow[i] = null;
                }
            }
        }


        private void Button_OnClick(object sender, EventArgs e)
        {
            if (!timer.IsEnabled)
            {
                timer.Start();
                ButtonStart.Content = "Stop";
                StartAd();
            }
            else
            {
                timer.Stop();
                ButtonStart.Content = "Start";
            }
        }

        private void OnTimer(object sender, EventArgs e)
        {
            mainGrid.Update();
            genCounter++;
            lblGenCount.Content = "Generations: " + genCounter;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Clear();
        }


    }
}
