using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Zajecia13
{
    public class LabelGenerator : IControlGenerator
    {

        public LabelGenerator()
        {

        }
        public FrameworkElement Generate()
        {
            return new Label()
            {
                Content = "LabelGenerator",
                Background = Brushes.Red,
            };
        }
    }
}
