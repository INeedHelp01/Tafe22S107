﻿using System;
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
	public sealed partial class MainMenu : Page
	{
		public MainMenu()
		{
			this.InitializeComponent();
		}

		private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage));
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MortgageCalculatorPage));
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(CurrencyConversion));
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			//Trip Calulator Code will be devoleped later
		}
	}
}
