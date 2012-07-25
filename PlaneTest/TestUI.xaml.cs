using System;
using System.Windows;
using System.Windows.Controls;

namespace PlaneTest
{
    public partial class TestUI : UserControl
    {
        public TestUI()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _sliderX.Value = Math.Round(_sliderX.Value / 180) * 180;
            _sliderY.Value = Math.Round(_sliderY.Value / 180) * 180;
        }
    }
}
