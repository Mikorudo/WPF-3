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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_3
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			List<int> fontSizes = GetFontSizes();
			//Binding b = new Binding();
			//b.Source = fontSizes;
			//b.Path = 
		}
		private List<int> GetFontSizes()
		{
			List<int> fontSizes = new List<int>();
			for (int i = 8; i < 12; i++)
				fontSizes.Add(i);
			for (int i = 12; i <= 28; i++)
				if (i % 2 == 0)
					fontSizes.Add(i);
			fontSizes.Add(36);
			fontSizes.Add(48);
			fontSizes.Add(72);
			return fontSizes;
		}

		private void ChangeColor(object sender, RoutedEventArgs e)
		{
			Button button = sender as Button;
			Binding b = new Binding();
			b.Source = button;
			b.Path = new PropertyPath("Background");
			b.Mode = BindingMode.OneTime;
			MainButton.SetBinding(Button.BackgroundProperty, b);
		}

		private void MainButton_Click(object sender, RoutedEventArgs e)
		{
			this.Title = (sender as Button).Content.ToString();
			MessageBox.Show(this.Title);
		}
	}
}
