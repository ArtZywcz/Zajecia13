using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zajecia13
{
    public class PanelFiller : IPanelFiller
    {
        public IControlGenerator _controlGenerator { get; private set; }
        public IDataProvider _dataProvider { get; private set; }

        public PanelFiller(IControlGenerator controlGenerator, IDataProvider dataProvider)
        {
            _controlGenerator = controlGenerator;
            _dataProvider = dataProvider;
        }
        public void Fill(Panel panel)
        {
            var number = _dataProvider.GetData();
            for (int i = 0; i < number; i++)
            {
                panel.Children.Add(_controlGenerator.Generate());
            }
        }
    }
}
