using SoulverDotNet.Core;
using System.Windows;

namespace WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void SetLineNumbers()
		{
			// always show a number for line 1, even with no content
			txtLineNumbers.Text = $"1{Environment.NewLine}";

			for (int i = 2; i <= txtQuestions.LineCount; i++)
			{
				txtLineNumbers.Text += $"{i}{Environment.NewLine}";
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			SetLineNumbers();
		}

		private void txtQuestions_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			SetLineNumbers();

			string[] questionLines = txtQuestions.Text.Split(Environment.NewLine);
			string[] answerLines = QuestionParser.Parse(questionLines);

			txtAnswers.Text = string.Join(Environment.NewLine, answerLines);
		}
	}
}