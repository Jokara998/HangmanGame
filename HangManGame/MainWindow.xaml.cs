using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            mw.MaxHeight = 460;
            mw.MaxWidth = 810;
            mw.MinHeight = 440;
            mw.MinWidth = 790;
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
            
            // 100 word mode
            HundredWords game = new HundredWords();
            game.MaxHeight = 635;
            game.MaxWidth = 963;
            game.MinHeight = 634;
            game.MinWidth = 965;
            game.Show();
            Hide();
            
            

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
