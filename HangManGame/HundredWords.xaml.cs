using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HangManGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>

    public partial class HundredWords : Window
    {
        public List<string> words;
        public List<string> words100;
        public string wordRandom;
        List<Button> buttons;
        public int guesses = 9;
        public int win = 0;
        public int finalWin = 0;
        public Boolean begin = true;
        public int countWords = 0;
        public int mode;

        public HundredWords(int modeNumber)
        {
            InitializeComponent();
            mode = modeNumber;
            Random100Words();
            RandomWord();
            AddButtons();
            menu.ItemsSource = buttons;
            begin = false;

        }

        private void Exit2_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.MaxHeight = 510;
            mw.MaxWidth = 825;
            mw.MinHeight = 500;
            mw.MinWidth = 815;
            mw.Show();


        }

        public void RandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, words100.Count);
            wordRandom = words100[index];

            if (!begin)
                leftWin.Content = "Games left to win:" + words100.Count;
            else
            {
                leftWin.Content = "Games left to win:"+ words100.Count;
                begin = false;
            }
            
            words100.Remove(wordRandom);
            Console.WriteLine(wordRandom);
       
        }

        public void Random100Words()
        {
            if (!begin)
                return;

            Random random = new Random();
            List<string> words64 = File.ReadAllLines(@"Words/words.txt").ToList();
            words = new List<string>();

            foreach (string w in words64)
            {
                words.Add(Base64Decode(w));
            }

            Console.ReadLine();

            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count != mode)
            {
                numbers.Add(random.Next(0, words.Count));
              
            }

            words100 = new List<string>();
            foreach(int ix in numbers)
            {
                words100.Add(words[ix]);
                ++countWords;
            }
           
           

        }

        public void AddButtons()
        {
            int lenWords = wordRandom.Length;
            buttons = new List<Button>();
            int index = 0;
            while (index != lenWords)
            {


                Button b = new Button();
                b.IsEnabled = false;
                b.Name = "b" + index;
                b.HorizontalAlignment = HorizontalAlignment.Left;
                b.VerticalAlignment = VerticalAlignment.Top;
                b.FontSize = 27;
                b.Width = 50;
                b.Height = 44;
                b.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD8D8D8"));
                b.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD8D8D8"));
                b.BorderThickness = new Thickness(3, 3, 3, 3);
                b.FontFamily = new FontFamily("Face Your Fears");
                b.Style = (Style)FindResource(ToolBar.ButtonStyleKey);
                b.Content = "";

                buttons.Add(b);
                ++index;

            }
        }

        private void WordGuessHundred(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();
            (sender as Button).IsEnabled = false;
            (sender as Button).Visibility = Visibility.Hidden;
            string wordFor = wordRandom.ToUpper();


            if (wordFor.Contains(content))
            {

                for (int i = 0; i < wordFor.Length; i++)
                {
                    string letter = wordFor[i].ToString();

                    if (letter.Equals(content))
                    {
                        buttons[i].Content = content;
                        ++win;
                    }
                }


            }
            else
            {
                --guesses;
                UpdateHangMan();
            }

            if (win == wordFor.Length && finalWin != countWords)
            {
                ++finalWin;
                Message("You Won!Continue Next Level?", "HangManGame");
            }else if (win == wordFor.Length && finalWin == countWords) {
                Message("You Won 100 Words Mode! Congratz!", "HangManGame");
            }



        }
        private void UpdateHangMan()
        {
            switch (guesses)
            {
                case 9:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_0.png", UriKind.Relative));
                    break;
                case 8:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_1.png", UriKind.Relative));
                    break;
                case 7:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_2.png", UriKind.Relative));
                    break;
                case 6:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_3.png", UriKind.Relative));
                    break;
                case 5:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_4.png", UriKind.Relative));
                    break;
                case 4:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_5.png", UriKind.Relative));
                    break;
                case 3:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_6.png", UriKind.Relative));
                    break;
                case 2:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_7.png", UriKind.Relative));
                    break;
                case 1:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_8.png", UriKind.Relative));
                    break;
                case 0:
                    hangmanHundred.Source = new BitmapImage(new Uri(@"Images/image_9.png", UriKind.Relative));
                    Message("You Lost!New Game?", "HangManGame");

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        public void Message(string body, string tittle)
        {
            MessageBoxResult result = MessageBox.Show(body, tittle, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                if(body.Equals("You Won!Continue Next Level?"))
                    UpdateGame();
                else if (body.Equals("You Lost!New Game?"))
                {
                    this.Close();
                    guesses = 9;
                    win = 0;
                    finalWin = 0;
                    begin = true;
                    countWords = 0;
                    HundredWords game = new HundredWords(mode);
                    game.MaxHeight = 635;
                    game.MaxWidth = 963;
                    game.MinHeight = 634;
                    game.MinWidth = 965;
                    game.Show();

                }
                else
                {
                    Close();
                    guesses = 9;
                    win = 0;
                    finalWin = 0;
                    begin = true;
                    countWords = 0;
                    MainWindow mw = new MainWindow();
                    mw.Show();
                }
            
            }
            else
            {
                Close();
                guesses = 9;
                win = 0;
                finalWin = 0;
                begin = true;
                countWords = 0;
                MainWindow mw = new MainWindow();
                mw.Show();
            }
        }

        private void FinalGuessHundred(object sender, RoutedEventArgs e)
        {
            if (word.Text.Equals(""))
                return;

            string wordFinal = word.Text.Trim().ToUpper();
            if (wordFinal.Equals(wordRandom.ToUpper()))
            {
                for (int i = 0; i < wordRandom.Length; i++)
                {
                    buttons[i].Content = wordFinal[i].ToString();
                }

                ++finalWin;

                if (finalWin != countWords)
                {
                    Message("You Won!Continue Next Level?", "HangManGame");
                }
                else
                {
                    Message("You Won 100 Words Mode! Congratz!", "HangManGame");
                }

            }
            else
            {
                guesses = guesses - 2;

                if (guesses < 0)
                    guesses = 0;

                UpdateHangMan();

                if (guesses == 0)
                {
                    Message("You Lost!New Game?", "HangManGame");
                }
                else
                {
                    word.Text = "";
                }
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void UpdateGame()
        {
            guesses = 9;
            win = 0;
            word.Text = "";
            RandomWord();
            AddButtons();
            menu.ItemsSource = buttons;
            begin = false;
            UpdateHangMan();
        }
    }
}
