using System.Windows;
using System.Windows.Media;

namespace ScatterPlane
{
    public static class VisualTree
    {
        // Stolen: http://msdn.microsoft.com/en-us/library/bb613579.aspx
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter" )]
        public static T FindVisualChild<T>( this DependencyObject obj )
            where T : DependencyObject
        {
            for ( int i = 0; i < VisualTreeHelper.GetChildrenCount( obj ); i++ )
            {
                DependencyObject child = VisualTreeHelper.GetChild( obj, i );
                if ( child != null && child is T )
                {
                    return ( T ) child;
                }
                else
                {
                    T childOfChild = FindVisualChild<T>( child );
                    if ( childOfChild != null )
                    {
                        return childOfChild;
                    }
                }
            }
            return null;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter" )]
        public static T FindVisualParent<T>( this DependencyObject obj )
            where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent( obj );
            while ( parent != null )
            {
                T typed = parent as T;
                if ( typed != null )
                {
                    return typed;
                }
                parent = VisualTreeHelper.GetParent( parent );
            }
            return null;
        }
    }
}
