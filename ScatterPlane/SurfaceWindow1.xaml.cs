using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;

namespace ScatterPlane
{
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        public SurfaceWindow1()
        {
            InitializeComponent();
        }

        private void SurfaceButton_ContactTapGesture(object sender, ContactEventArgs e)
        {
            SurfaceButton surfaceButton = sender as SurfaceButton;
            ScatterViewItem scatterViewItem = surfaceButton.FindVisualParent<ScatterViewItem>();
            ScatterFlip.SetIsFlipped(scatterViewItem, !ScatterFlip.GetIsFlipped(scatterViewItem));
        }
    }
}