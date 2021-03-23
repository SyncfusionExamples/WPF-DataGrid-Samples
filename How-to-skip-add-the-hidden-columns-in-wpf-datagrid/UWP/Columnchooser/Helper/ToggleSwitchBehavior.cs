using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SfDataGridDemo
{
    public class ToggleEx
    {
        public static readonly DependencyProperty CommandProperty = DependencyProperty.RegisterAttached("Command", typeof(ICommand),
        typeof(ToggleEx), new PropertyMetadata(null, PropertyChangedCallback));

        public static void PropertyChangedCallback(DependencyObject depObj, DependencyPropertyChangedEventArgs args)
        {
            ToggleSwitch toggleSwitch = depObj as ToggleSwitch;
            if (toggleSwitch != null)
                toggleSwitch.Toggled += toggleSwitch_Toggled;
        }

        static void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch Switch = (sender as ToggleSwitch);
            if (Switch != null)
            {
                ICommand command = Switch.GetValue(CommandProperty) as ICommand;
                if (command != null)
                {
                    command.Execute(Switch.IsOn);
                }
            }
        }


        public static ICommand GetCommand(UIElement element)
        {
            return (ICommand)element.GetValue(CommandProperty);
        }

        public static void SetCommand(UIElement element, ICommand command)
        {
            element.SetValue(CommandProperty, command);
        }
    }
}
