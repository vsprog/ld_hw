using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculatorv1
{
    public partial class MainWindow : Window
    {
        private readonly ExpressionEvaluator evaluator;

        public MainWindow()
        {
            InitializeComponent();
            evaluator = new ExpressionEvaluator();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            var expression = tb.Text;
            var operators = new Regex(@"[*/+\-]");

            if (expression.Contains("=")) tb.Text = string.Empty;

            if (expression.Length > 0 && 
                operators.IsMatch(expression.Last().ToString()) && 
                operators.IsMatch(button.Content.ToString()))
                tb.Text = expression.Substring(0, expression.Length-1);

            tb.Text += button.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e) => Evaluate();

        private void Evaluate()
        {
            var expression = tb.Text;
            if (expression.Contains("=") || string.IsNullOrEmpty(expression)) return;

            var result = evaluator.Calculate(expression);

            tb.Text += "=" + result;
        }

        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = string.Empty;
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }
    }
}