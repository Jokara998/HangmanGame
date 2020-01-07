using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HangManGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>

    public partial class Game : Window
    {
        public List<string> words;
        public string wordRandom;
        List<Button> buttons;

        public Game()
        {
            InitializeComponent();
            RandomWord();
            AddButtons();
            menu.ItemsSource = buttons;

        }

        private void Exit2_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mw = new MainWindow();
            mw.Show();

        }

        public void RandomWord()
        {
            Random random = new Random();
            words = File.ReadAllLines(@"Words/words.txt").ToList();
            Console.ReadLine();
            int index = random.Next(0, words.Count);
            wordRandom = words[index];
            Console.WriteLine(wordRandom);
        }

        public void AddButtons()
        {
            int lenWords = wordRandom.Length;
            buttons = new List<Button>();
            int index = 0;
            int x = 120;
            int y = 391;
            while(index != lenWords)
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

                buttons.Add(b);
                ++index;

            }
        }



    }
}
