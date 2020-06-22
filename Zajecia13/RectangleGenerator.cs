using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Zajecia13
{
    public class RectangleGenerator : IControlGenerator
    {
        public FrameworkElement Generate()
        {
            return new Rectangle()
            {
                Height = 20,
                Width = 20,
                Fill = new SolidColorBrush(Colors.Red),
                Margin = new Thickness(0, 5, 0, 5),
            };
        }
    }
}
