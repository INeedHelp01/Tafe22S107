using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyConversion : Page
	{
		public CurrencyConversion()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
			double amount;
			amount = double.Parse(AmountTextBox.Text);
			double conversion;

			if (FromComboBox.SelectedIndex == 0)
			{
				if (ToComboBox.SelectedIndex == 2)
				{
					conversion = CalMoneyToPoundFromUS(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 3)
				{
					conversion = CalMoneyToRupeeFromUS(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 1)
				{
					conversion = CalMoneyToEuroFromUS(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}

			}
			if (FromComboBox.SelectedIndex == 1)
			{
				if (ToComboBox.SelectedIndex == 3)
				{
					conversion = CalMoneyToRupeeFromEuro(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 2)
				{
					conversion = CalMoneyToPoundFromEuro(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 0)
				{
					conversion = CalMoneyToUSfromEuro(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
					;
				}

			}
			if (FromComboBox.SelectedIndex == 2)
			{
				if (ToComboBox.SelectedIndex == 0)
				{
					conversion = CalPoundToUS(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);

				}
				else if (ToComboBox.SelectedIndex == 1)
				{
					conversion = CalPoundToEuro(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 3)
				{
					conversion = CalPoundToRupee(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}


			}
			if (FromComboBox.SelectedIndex == 3)
			{
				if (ToComboBox.SelectedIndex == 0)
				{
					conversion = CalRupeeToUS(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 1)
				{
					conversion = CalRupeeToEuro(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);
				}
				else if (ToComboBox.SelectedIndex == 2)
				{
					conversion = CalRupeeToPound(amount);
					ConversionAmountTextBlock.Text = Convert.ToString(conversion);

				}


			}
		}
		private double CalMoneyToPoundFromUS(double amount)
		{
			const double pound = 0.72872436;
			FromToTextBlock.Text = "1 USD = " + pound + " British Pound";
			ToFromTextBlock.Text = "1 British Pound = 1.371907 USD"; 
			double total;
			total = pound * amount;
			return total;
			
			
		}
		private double CalMoneyToEuroFromUS(double amount)
		{
			const double euro = 0.855189982;
			FromToTextBlock.Text = "1 USD = " + euro + " Euro";
			ToFromTextBlock.Text = "1 Euro = 1.1739732USD ";
			double total;
			total = euro * amount;
			return total;
		}
		private double CalMoneyToRupeeFromUS(double amount)
		{
			const double ruppe = 74.257327;
			FromToTextBlock.Text = "1 USD = " + ruppe + "Rupee";
			ToFromTextBlock.Text = "1 Rupee = 0.011492628 USD"; 
			double total;
			total = ruppe * amount;
			return total;
		}
		private double CalMoneyToUSfromEuro(double amount)
		{
			const double us = 1.1739732;
			FromToTextBlock.Text = "1 Euro = " + us + "USD";
			ToFromTextBlock.Text = "1 USD = 0.8518992 Euro";
			double total;
			total = us * amount;
			return total;
		}
		private double CalMoneyToPoundFromEuro(double amount)
		{
			const double pound = 0.8556672;
			FromToTextBlock.Text = "1 Euro = " + pound + "British Pound";
			ToFromTextBlock.Text = "1 Pound = 1.1686692 Euro";
			double total;
			total = pound * amount;
			return total;
		}
		private double CalMoneyToRupeeFromEuro(double amount)
		{
			const double rupee = 87.00755;
			FromToTextBlock.Text = "1 Euro = " + rupee + "Rupee";
			ToFromTextBlock.Text = "1 Rupee = 0.013492774 Euro ";
			double total;
			total = rupee * amount;
			return total;
		}
		private double CalPoundToUS(double amount)
		{
			const double us = 1.371907;
			FromToTextBlock.Text = "1 British Pound = " + us + "USD";
			ToFromTextBlock.Text = "1 USD = 0.72872436 British Pound";
			double total;
			total = us * amount;
			return total;
		}
		private double CalPoundToEuro(double amount)
		{
			const double euro = 1.1686692;
			FromToTextBlock.Text = "1 British Pound = " + euro + "Euro";
			ToFromTextBlock.Text = "1 Euro = 0.8556672 British Pound";
			double total;
			total = euro * amount;
			return total;

		}
		private double CalPoundToRupee(double amount)
		{
			const double rupee = 101.68635;
			FromToTextBlock.Text = "1 British Pound = " + rupee + "Rupee";
			ToFromTextBlock.Text = "1 Rupee = 0.0098339397 British Pound";
			double total;
			total = rupee * amount;
			return total;
		}
		private double CalRupeeToUS(double amount)
		{
			const double us = 0.01492628;
			FromToTextBlock.Text = "1 Rupee = " + us + "USD";
			ToFromTextBlock.Text = "1 USD = 74.257327 Rupee";
			double total;
			total = us * amount;
			return total;
		}
		private double CalRupeeToEuro(double amount)
		{
			const double euro = 0.0113492774;
			FromToTextBlock.Text = "1 Rupee = " + euro + "Euro";
			ToFromTextBlock.Text = "1 Euro = 87.00755 Rupee";
			double total;
			total = euro * amount;
			return total;

		}
		private double CalRupeeToPound(double amount)
		{
			const double pound = 0.0098339397;
			FromToTextBlock.Text = "1 Rupee = " + pound + "British Pound";
			ToFromTextBlock.Text = "1 British Pound = 101.68635;";
			double total;
			total = pound * amount;
			return total;
		}

	}
}
