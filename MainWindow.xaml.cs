﻿using System;
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

namespace WPF_images
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Ресурс , *.png 

    public partial class MainWindow : Window
    {
        Point currentPoint = new Point();
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void Image_Loaded(object sender, RoutedEventArgs e)
        //{
        //    BitmapImage bitmapImage = new BitmapImage();
        //    // Call BaseUri on the root Page element and combine it with a relative path
        //    // to consruct an absolute URI.
        //    bitmapImage.UriSource = new Uri("cad.png", UriKind.Relative);
        //    myImage.Source = bitmapImage;
        //}
        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);
        }

        private void Canvas_MouseMove_1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();
                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;
                currentPoint = e.GetPosition(this);
                paintSurface.Children.Add(line);
            }
        }
    }
}
