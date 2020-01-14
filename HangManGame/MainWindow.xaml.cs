using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HangManGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.MaxHeight = 510;
            mw.MaxWidth = 825;
            mw.MinHeight = 500;
            mw.MinWidth = 815;
         
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            
            Game game = new Game();
            game.MaxHeight = 635;
            game.MaxWidth = 963;
            game.MinHeight = 634;
            game.MinWidth = 965;
            game.Show();
            Hide();
           
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if(Exit.Content.Equals("Exit"))
                System.Windows.Application.Current.Shutdown();
          
        }

        
        private void Words_Click(object sender, RoutedEventArgs e)
        {
            string modeName = (sender as Button).Content.ToString();
            int modeNumber = 0;

            if (modeName.Equals("Easy Mode"))
            {
                modeNumber = 5;
            }
            else if (modeName.Equals("Medium Mode"))
            {
                modeNumber = 20;
            }
            else if (modeName.Equals("Hard Mode"))
            {
                modeNumber = 40;
            }
            else if (modeName.Equals("Extreme Mode"))
            {
                modeNumber = 80;
            }

            HundredWords game = new HundredWords(modeNumber);
            game.MaxHeight = 635;
            game.MaxWidth = 963;
            game.MinHeight = 634;
            game.MinWidth = 965;

            game.Show();
            Hide();
                 

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

    }
}
