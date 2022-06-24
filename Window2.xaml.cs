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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab2
{
	/// <summary>
	/// Логика взаимодействия для Window2.xaml
	/// </summary>
	public partial class Window2 : Window
	{
		double a;
		
		public Window2()
		{
			InitializeComponent();
		}

		private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
		{
			abc.DefaultDrawingAttributes.Color = Colors.Red;
		}

		private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
		{
			abc.DefaultDrawingAttributes.Color = Colors.Green;
		}

		private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
		{
			abc.DefaultDrawingAttributes.Color = Colors.Blue;
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (abc != null)
			{
				a = be.Value;
				be.Value = Math.Round(e.NewValue, 0);
				abc.DefaultDrawingAttributes.Width = a;
				abc.DefaultDrawingAttributes.Height = a;
				val.Text = be.Value.ToString();
			}
		}

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
			abc.EditingMode = InkCanvasEditingMode.EraseByPoint;
		}

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
			abc.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
			abc.EditingMode = InkCanvasEditingMode.Select;
        }

        
    }
}
