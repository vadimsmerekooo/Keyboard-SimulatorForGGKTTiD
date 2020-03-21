using System;
using System.Windows.Input;

namespace KSGGKTTiD.Resource.Window
{
    /// <summary>
    /// Логика взаимодействия для AythRegWIndow.xaml
    /// </summary>
    public partial class AythRegWIndow : System.Windows.Window
    {
        public AythRegWIndow()
        {
            InitializeComponent();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
