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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar
{
    public partial class PageDay : Page
    {
        public PageDay()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ColorAnimation colorAnim = new ColorAnimation();
            colorAnim.From = ((SolidColorBrush)BackButton.Background).Color;
            colorAnim.To = Colors.White;
            colorAnim.FillBehavior = FillBehavior.Stop;
            colorAnim.Duration = TimeSpan.FromSeconds(1);  
            BackButton.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);

            ColorAnimation colorTextAnim = new ColorAnimation();
            colorTextAnim.From = ((SolidColorBrush)BackButton.Foreground).Color;
            colorTextAnim.To = Colors.Red;
            colorTextAnim.FillBehavior = FillBehavior.Stop;
            colorTextAnim.Duration = TimeSpan.FromSeconds(1);
            BackButton.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ColorAnimation colorAnim = new ColorAnimation();
            colorAnim.From = ((SolidColorBrush)BackButton.Background).Color;
            colorAnim.To = Colors.White;
            colorAnim.FillBehavior = FillBehavior.Stop;
            colorAnim.Duration = TimeSpan.FromSeconds(1);
            BackButton.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);

            ColorAnimation colorTextAnim = new ColorAnimation();
            colorTextAnim.From = ((SolidColorBrush)BackButton.Foreground).Color;
            colorTextAnim.To = Colors.Red;
            colorTextAnim.FillBehavior = FillBehavior.Stop;
            colorTextAnim.Duration = TimeSpan.FromSeconds(1);
            BackButton.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, colorAnim);
        }
    }
}
