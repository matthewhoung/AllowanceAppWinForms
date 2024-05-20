using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AllowanceApp
{
    public partial class Form1 : Form
    {
        private List<Expense> expenses = new List<Expense>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var inputLines = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var line in inputLines)
            {
                if (TryParseExpense(line, out Expense expense))
                {
                    expense.Date = monthCalendar1.SelectionStart;
                    expenses.Add(expense);
                }
            }
            DisplayExpenses();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            var startDate = monthCalendar1.SelectionStart;
            var endDate = monthCalendar1.SelectionEnd;
            var filteredExpenses = expenses.Where(x => x.Date >= startDate && x.Date <= endDate).ToList();

            var summary = filteredExpenses
                .GroupBy(x => x.Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Total = g.Sum(x => x.Amount)
                });

            textBox2.Clear();
            foreach (var item in summary)
            {
                textBox2.AppendText($"{item.Name}: {item.Total:C}{Environment.NewLine}");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            expenses.Clear();
        }

        private bool TryParseExpense(string input, out Expense expense)
        {
            expense = null;
            var parts = input.Split(new[] { ':', '$' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 3) return false;

            var name = parts[0].Trim();
            var description = parts[1].Trim();
            if (!decimal.TryParse(parts[2].Trim(), NumberStyles.Currency, CultureInfo.CurrentCulture, out var amount))
                return false;

            expense = new Expense
            {
                Name = name,
                Description = description,
                Amount = amount
            };

            return true;
        }

        private void DisplayExpenses()
        {
            textBox2.Clear();
            foreach (var expense in expenses)
            {
                textBox2.AppendText($"{expense.Date.ToShortDateString()} {expense.Name}: {expense.Description} {expense.Amount:C}{Environment.NewLine}");
            }
        }
    }
}
