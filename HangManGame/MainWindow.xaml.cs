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
        static char[] chars = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
            'y', 'z', '0', '1', '2', '3', '4', '5',
            '6', '7', '8', '9', 'A', 'B', 'C', 'D',
            'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z',
        };
        public List<string> words = new List<string>();

        public MainWindow()
        {

            InitializeComponent();
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.MaxHeight = 510;
            mw.MaxWidth = 825;
            mw.MinHeight = 500;
            mw.MinWidth = 815;

            List<string> words64 = File.ReadAllLines(@"Words/words.txt").ToList();
            words = new List<string>();

            foreach (string w in words64)
            {
                words.Add(Decrypt(Base64Decode(w), 5));
            }

            Console.ReadLine();


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
                modeNumber = 15;
            }
            else if (modeName.Equals("Hard Mode"))
            {
                modeNumber = 30;
            }
            else if (modeName.Equals("Extreme Mode"))
            {
                modeNumber = 50;
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

        static string Decrypt(string cip, int offset)
        {
            char[] cipher = cip.ToCharArray();

            for (int i = 0; i < cipher.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (j >= offset && cipher[i] == chars[j])
                    {
                        cipher[i] = chars[j - offset];
                        break;
                    }
                    if (cipher[i] == chars[j] && j < offset)
                    {
                        cipher[i] = chars[(chars.Length - offset + 1) + j];
                        break;
                    }
                }
            }
            return new string(cipher);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
