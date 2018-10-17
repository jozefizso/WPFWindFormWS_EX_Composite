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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsFormsApplication2
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            this.Loaded += UserControl2_Loaded;
        }

        void UserControl2_Loaded(object sender, RoutedEventArgs e)
        {
            HwndSource hwnd = System.Windows.PresentationSource.FromVisual(this) as HwndSource;
            HwndTarget target = hwnd.CompositionTarget;
            target.RenderMode = RenderMode.SoftwareOnly;
        }
    }
}
