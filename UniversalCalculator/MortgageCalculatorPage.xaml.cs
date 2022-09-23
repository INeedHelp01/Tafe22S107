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
	public sealed partial class MortgageCalculatorPage : Page
	{
		public MortgageCalculatorPage()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (borrowAmountTextBox.Text == "")
			{
				borrowAmountTextBox.Text = "0";
			}
			else if (yearsTextBox.Text == "")
			{
				yearsTextBox.Text = "0";
			}
			else if (monthsTextBox.Text == "")
			{
				monthsTextBox.Text = "0";
			}
			else if (yearInterestRateTextBox.Text == "")
			{
				yearInterestRateTextBox.Text = "0";
			}
			double borrowAmt = Convert.ToDouble(borrowAmountTextBox.Text);
			double lengthYear = Convert.ToDouble(yearsTextBox.Text) * 12;
			double lengthMonths = Convert.ToDouble(monthsTextBox.Text);
			double yearlyInterestRate = Convert.ToDouble(yearInterestRateTextBox.Text) / 100;

			double loanLength = lengthMonths + lengthYear;
			double monthlyInterestRate = yearlyInterestRate / 12;


			double termOfLoan = Math.Pow(1 + monthlyInterestRate, loanLength);

			double monthlyRepayment = Math.Round( borrowAmt * ((monthlyInterestRate * termOfLoan) / (termOfLoan -1)), 2);
			monthlyInterestRate = Math.Round(monthlyInterestRate, 5);
			monthlyInterestRateTextBox.Text = Convert.ToString(monthlyInterestRate) + "%";
			monthlyRepaimentTextBox.Text = "$" + Convert.ToString(monthlyRepayment);
		}
	}
}
