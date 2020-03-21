﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace KSGGKTTiD
{
    public partial class MainWindow : Window
    {

        private int tempTimer = 0;
        private int fails = 0;
        private void CapitalLetters()
        {
            this.Q.Content = "Q";
            this.W.Content = "W";
            this.E.Content = "E";
            this.R.Content = "R";
            this.T.Content = "T";
            this.Y.Content = "Y";
            this.U.Content = "U";
            this.I.Content = "I";
            this.O.Content = "O";
            this.P.Content = "P";
            this.A.Content = "A";
            this.S.Content = "S";
            this.D.Content = "D";
            this.F.Content = "F";
            this.G.Content = "G";
            this.H.Content = "H";
            this.J.Content = "J";
            this.K.Content = "K";
            this.L.Content = "L";
            this.Z.Content = "Z";
            this.X.Content = "X";
            this.C.Content = "C";
            this.V.Content = "V";
            this.B.Content = "B";
            this.N.Content = "N";
            this.M.Content = "M";

        }
        private void LoverLetters()
        {
            this.Q.Content = "q";
            this.W.Content = "w";
            this.E.Content = "e";
            this.R.Content = "r";
            this.T.Content = "t";
            this.Y.Content = "y";
            this.U.Content = "u";
            this.I.Content = "i";
            this.O.Content = "o";
            this.P.Content = "p";
            this.A.Content = "a";
            this.S.Content = "s";
            this.D.Content = "d";
            this.F.Content = "f";
            this.G.Content = "g";
            this.H.Content = "h";
            this.J.Content = "j";
            this.K.Content = "k";
            this.L.Content = "l";
            this.Z.Content = "z";
            this.X.Content = "x";
            this.C.Content = "c";
            this.V.Content = "v";
            this.B.Content = "b";
            this.N.Content = "n";
            this.M.Content = "m";

        }
        private void CapitalSymbol()
        {
            this.Oem3.Content = "~";
            this.D1.Content = "!";
            this.D2.Content = "@";
            this.D3.Content = "#";
            this.D4.Content = "$";
            this.D5.Content = "%";
            this.D6.Content = "^";
            this.D7.Content = "&";
            this.D8.Content = "*";
            this.D9.Content = "(";
            this.D0.Content = ")";
            this.OemMinus.Content = "_";
            this.OemPlus.Content = "+";
            this.OemOpenBrackets.Content = "{";
            this.Oem6.Content = "}";
            this.Oem5.Content = "|";
            this.Oem1.Content = ":";
            this.OemQuotes.Content = "\"";
            this.OemComma.Content = "<";
            this.OemPeriod.Content = ">";
            this.OemQuestion.Content = "?";
        }
        private void LoverSymbol()
        {
            this.Oem3.Content = "`";
            this.D1.Content = "1";
            this.D2.Content = "2";
            this.D3.Content = "3";
            this.D4.Content = "4";
            this.D5.Content = "5";
            this.D6.Content = "6";
            this.D7.Content = "7";
            this.D8.Content = "8";
            this.D9.Content = "9";
            this.D0.Content = "0";
            this.OemMinus.Content = "-";
            this.OemPlus.Content = "=";
            this.OemOpenBrackets.Content = "[";
            this.Oem6.Content = "]";
            this.Oem5.Content = "\\";
            this.Oem1.Content = ";";
            this.OemQuotes.Content = "'";
            this.OemComma.Content = ",";
            this.OemPeriod.Content = ".";
            this.OemQuestion.Content = "/";
        }

        Random rendChar = new Random();
        string baceString = "QWERTYUIOPASDFGHJKLZXCVBNM~!@#$%^&*()_+{}|:\"<>?1234567890[],./\\`-=;'qwertyuiopasdfghjklzxcvbnm";
        bool flagCapsLock = true;
        bool flagBackspase = true;
        private bool backClick = false;
        bool mesStop = true;
        DispatcherTimer timer = null;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            Combobox.ItemsSource = new string[] {"Легкий", "Средний", "Тяжелый", "Супер-тяжелый" };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempTimer++;
            Speed();
        }
        private void CollectString(int countChar, string baceString, bool flagSensitive)
        {
            string carhs = "";
            int sensitive = (flagSensitive) ? 47 : 0;
            for (int i = 0; i < countChar; i++)
            {
                carhs += baceString[rendChar.Next(sensitive, baceString.Length)];
            }
            carhs += " ";
            int countString = (flagSensitive) ? 75 : 70;
            for (int i = 0; i < countString; i++)
            {
                linePrograms.Text += carhs[rendChar.Next(0, carhs.Length)];
            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            foreach (UIElement it in (this.Content as Grid).Children)
            {
                if (it is Grid)
                {
                    foreach (var item in (it as Grid).Children)
                    {
                        if (item is Button)
                        {
                            if ((item as Button).Name == e.Key.ToString())
                            {
                                (item as Button).Opacity = 0.5;
                                if (e.Key.ToString() == "LeftShift" || e.Key.ToString() == "RightShift")
                                {
                                    CapitalSymbol();
                                    if (flagCapsLock)
                                    {
                                        CapitalLetters();
                                    }
                                    else
                                    {
                                        LoverLetters();
                                    }
                                }
                                else if (e.Key.ToString() == "Capital")
                                {
                                    if (flagCapsLock)
                                    {
                                        CapitalLetters();
                                        flagCapsLock = false;
                                    }
                                    else
                                    {
                                        LoverLetters();
                                        flagCapsLock = true;
                                    }
                                }
                                else if (e.Key.ToString() == "Back")
                                {
                                    flagBackspase = false;
                                    backClick = true;
                                }
                                else
                                {
                                    backClick = false;
                                    flagBackspase = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Window_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (lineUser.IsEnabled)
            {
                lineUser.Focus();
            }

            foreach (UIElement it in (this.Content as Grid).Children)
            {
                if (it is Grid)
                {
                    foreach (var item in (it as Grid).Children)
                    {
                        if (item is Button)
                        {
                             if ((item as Button).Name == e.Key.ToString())
                            {
                                (item as Button).Opacity = 1;
                                if (e.Key.ToString() == "LeftShift" || e.Key.ToString() == "RightShift")
                                {
                                    LoverSymbol();
                                    if (!flagCapsLock)
                                    {
                                        CapitalLetters();
                                    }
                                    else
                                    {
                                        LoverLetters();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!mesStop)
            {

            }
        }

        private void lineUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lineUser.IsEnabled)
            {
                string str = linePrograms.Text.Substring(0, lineUser.Text.Length);
                if (lineUser.Text.Equals(str))
                {
                    if (flagBackspase )
                    {
                        Speed();
                    }
                    lineUser.Background = new SolidColorBrush(Color.FromRgb(46, 254, 46));
                    RectText.Fill = new SolidColorBrush(Color.FromRgb(46, 254, 46));
                }
                else
                {
                    if (flagBackspase && !backClick)
                    {
                        fails++;
                    }
                    lineUser.Background = new SolidColorBrush(Color.FromRgb(254, 46, 46));
                    RectText.Fill = new SolidColorBrush(Color.FromRgb(254, 46, 46));
                    Fails.Content = fails;
                }
                if (lineUser.Text.Length == linePrograms.Text.Length && lineUser.Text == linePrograms.Text)
                {
                    timer.Stop();
                    Speed();
                    lineUser.IsReadOnly = true;
                    mesStop = false;
                }
            }
        }
        void Speed()
        {
            SpeedChar.Content = Math.Round(((double)lineUser.Text.Length / tempTimer) * 60).ToString() + " с/м";
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            tempTimer = 0;
            timer.Start();
            linePrograms.Text = "Вадим Шкуратов Молодец, политик лидер и боец!";
            lineUser.IsReadOnly = false;
            lineUser.IsEnabled = true;
            lineUser.Text = string.Empty;
            lineUser.Focus();
            
        }

        bool StateClosed = true;
        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                sb.Begin();
            }

            StateClosed = !StateClosed;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            linePrograms.Text = "Вадим Шкуратов Молодец, политик лидер и боец!";
            lineUser.IsReadOnly = true;
            lineUser.IsEnabled = false;
            Fails.Content = 0.ToString();
            SpeedChar.Content = 0.ToString();
        }
    }
}
