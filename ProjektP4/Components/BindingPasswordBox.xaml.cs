using System;
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

namespace ProjektP4.Components
{
    /// <summary>
    /// Logika interakcji dla klasy BindingPasswordBox.xaml
    /// </summary>
    public partial class BindingPasswordBox : UserControl
    {

        private bool _isPasswordChanging;

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindingPasswordBox),
                new PropertyMetadata(string.Empty, PasswordPropertyChaneged));

        private static void PasswordPropertyChaneged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is BindingPasswordBox txtPass)
            {
                txtPass.UpdatePassword();
            }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public BindingPasswordBox()
        {
            InitializeComponent();
        }

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = txtPass.Password;
            _isPasswordChanging = false;
        }
        private void UpdatePassword()
        {
            if (!_isPasswordChanging)
            {
                txtPass.Password = Password;
            }
        }
    }
}

