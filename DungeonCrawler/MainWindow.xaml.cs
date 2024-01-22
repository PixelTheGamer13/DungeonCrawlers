﻿using System.Windows;
using System.Windows.Controls;

namespace DungeonCrawler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CharCreate();

        }

        private void CharCreate()
        {
            var frame = new Frame();
            frame.HorizontalAlignment = HorizontalAlignment.Stretch;
            frame.VerticalAlignment = VerticalAlignment.Stretch;
            AddChild(frame);
            frame.Navigate(new CharacterCreation());
        }
    }
}
