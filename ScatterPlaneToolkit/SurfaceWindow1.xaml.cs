using System.Windows;
using Microsoft.Surface.Presentation.Controls;

namespace ScatterPlaneToolkit
{
    /// <summary>
    /// Interaction logic for SurfaceWindow1.xaml
    /// </summary>
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        public SurfaceWindow1()
        {
            InitializeComponent();
        }

        private void SurfaceButton_Click(object sender, RoutedEventArgs e)
        {
            SurfaceButton surfaceButton = sender as SurfaceButton;
            ScatterViewItem scatterViewItem = surfaceButton.FindVisualParent<ScatterViewItem>();
            ScatterFlip.SetIsFlipped(scatterViewItem, !ScatterFlip.GetIsFlipped(scatterViewItem));
        }
    }
}