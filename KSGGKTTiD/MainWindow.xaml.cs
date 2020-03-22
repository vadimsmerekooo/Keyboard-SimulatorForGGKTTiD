using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
        private void LoverRusLetters()
        {
            this.Q.Content = "й";
            this.W.Content = "ц";
            this.E.Content = "у";
            this.R.Content = "к";
            this.T.Content = "е";
            this.Y.Content = "н";
            this.U.Content = "г";
            this.I.Content = "ш";
            this.O.Content = "щ";
            this.P.Content = "з";
            this.OemOpenBrackets.Content = "х";
            this.Oem6.Content = "ъ";
            this.A.Content = "ф";
            this.S.Content = "ы";
            this.D.Content = "в";
            this.F.Content = "а";
            this.G.Content = "п";
            this.H.Content = "р";
            this.J.Content = "о";
            this.K.Content = "л";
            this.L.Content = "д";
            this.Oem1.Content = "ж";
            this.OemQuotes.Content = "э";
            this.Z.Content = "я";
            this.X.Content = "ч";
            this.C.Content = "с";
            this.V.Content = "м";
            this.B.Content = "и";
            this.N.Content = "т";
            this.M.Content = "ь";
            this.OemComma.Content = "б";
            this.OemPeriod.Content = "ю";
            this.OemQuestion.Content = ".";
        }
        private void CapitalRusLetters()
        {
            this.Q.Content = "Й";
            this.W.Content = "Ц";
            this.E.Content = "У";
            this.R.Content = "К";
            this.T.Content = "Е";
            this.Y.Content = "Н";
            this.U.Content = "Г";
            this.I.Content = "Ш";
            this.O.Content = "Щ";
            this.P.Content = "З";
            this.OemOpenBrackets.Content = "Х";
            this.Oem6.Content = "Ъ";
            this.A.Content = "Ф";
            this.S.Content = "Ы";
            this.D.Content = "В";
            this.F.Content = "А";
            this.G.Content = "П";
            this.H.Content = "Р";
            this.J.Content = "О";
            this.K.Content = "Л";
            this.L.Content = "Д";
            this.Oem1.Content = "Ж";
            this.OemQuotes.Content = "Э";
            this.Z.Content = "Я";
            this.X.Content = "Ч";
            this.C.Content = "С";
            this.V.Content = "М";
            this.B.Content = "И";
            this.N.Content = "Т";
            this.M.Content = "Ь";
            this.OemComma.Content = "Б";
            this.OemPeriod.Content = "Ю";
            this.OemQuestion.Content = ",";
        }

        Random rendChar = new Random();
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
            LoverRusLetters();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempTimer++;
            Speed();
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
                                    
                                    if (flagCapsLock)
                                    {
                                        CapitalRusLetters();
                                    }
                                    else
                                    {
                                        LoverRusLetters();
                                    }
                                }
                                else if (e.Key.ToString() == "Capital")
                                {
                                    if (flagCapsLock)
                                    {
                                        CapitalRusLetters();
                                        flagCapsLock = false;
                                    }
                                    else
                                    {
                                        LoverRusLetters();
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
                                    if (!flagCapsLock)
                                    {
                                        CapitalRusLetters();
                                    }
                                    else
                                    {
                                        LoverRusLetters();
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
        private string RandomText(string slojn)
        {
            try
            {
                string[] text = null;
                if (slojn == "легкий")
                {
                    using (StreamReader sr = new StreamReader(@"../../Resource/Text/eazy.txt"))
                    {
                        text = File.ReadAllLines(@"../../Resource/Text/eazy.txt");
                    }
                }
                else if (slojn == "средний")
                {
                    using (StreamReader sr = new StreamReader(@"../../Resource/Text/midle.txt"))
                    {
                        text = File.ReadAllLines(@"../../Resource/Text/midle.txt");
                    }
                }
                else if (slojn == "тяжелый")
                {
                    using (StreamReader sr = new StreamReader(@"../../Resource/Text/hard.txt"))
                    {
                        text = File.ReadAllLines(@"../../Resource/Text/hard.txt");
                    }
                }
                else if (slojn == "супер-тяжелый")
                {
                    using (StreamReader sr = new StreamReader(@"../../Resource/Text/super-hard.txt"))
                    {
                        text = File.ReadAllLines(@"../../Resource/Text/super-hard.txt");
                    }
                }
                return text[rendChar.Next(0, text.Length - 1)];
            }
            catch
            {
                return "Че-то с файлами беда! Вызови фиксика Вадю. Он все починит))))";
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
            linePrograms.Text = RandomText(Combobox.SelectedValue.ToString().ToLower().Trim());
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
            lineUser.IsReadOnly = true;
            lineUser.IsEnabled = false;
            Fails.Content = 0.ToString();
            SpeedChar.Content = 0.ToString();
        }

        private void PackIcon_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            tempTimer = 0;
            timer.Start();
            linePrograms.Text = RandomText(Combobox.SelectedValue.ToString().ToLower());
            lineUser.IsReadOnly = false;
            lineUser.IsEnabled = true;
            lineUser.Text = string.Empty;
            Fails.Content = 0.ToString();
            SpeedChar.Content = 0.ToString();
            lineUser.Focus();
        }
        private void WindowMinimized_Click(object sender, RoutedEventArgs e) { this.WindowState = WindowState.Minimized; }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void WindowMaxNormal_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                WindowMaxNormal.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                WindowMaxNormal.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
            }
        }

        private void GridTitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void GridTitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }
    }
}
