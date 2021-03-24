using Syncfusion.UI.Xaml.Controls.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.UI.Xaml;

namespace SfDataGridDemo
{
    public class CustomTextBox : SfTextBoxExt
    {
        public CustomTextBox() : base()
        {

        }

        public static bool GetAutoSelectable(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoSelectableProperty);
        }

        public static void SetAutoSelectable(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoSelectableProperty, value);
        }

        public static readonly DependencyProperty AutoSelectableProperty =
            DependencyProperty.RegisterAttached(
                "AutoSelectable",
                typeof(bool),
                typeof(CustomTextBox),
                new PropertyMetadata(false, AutoFocusableChangedHandler));

        private static void AutoFocusableChangedHandler(
            DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                if ((bool)e.NewValue == true)
                {
                    (d as SfTextBoxExt).GotFocus += OnGotFocusHandler;
                }
                else
                {
                    (d as SfTextBoxExt).GotFocus -= OnGotFocusHandler;
                }
            }
        }

        private static void OnGotFocusHandler(object sender, RoutedEventArgs e)
        {
            (sender as SfTextBoxExt).SelectAll();
        }

    }
}
