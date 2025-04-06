using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
            LoadEnumTypes();

            WeekParsedLabel.Text = string.Empty;
        }

        private void LoadEnumTypes()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var enumTypes = assembly.GetTypes()
                .Where(t => t.IsEnum)
                .ToList();

            EnumsListBox.DataSource = enumTypes;

            EnumsListBox.DisplayMember = "Name";

            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
            }
        }

        private void EnumsListBoxIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem is Type selectedEnum) ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
        }

        private void ValuesListBoxIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem != null)
            {
                Type selectedEnum = EnumsListBox.SelectedItem as Type;

                if (selectedEnum != null)
                {
                    Array enumValues = Enum.GetValues(selectedEnum);


                    int selectedIndex = ValuesListBox.SelectedIndex;

                    if (selectedIndex >= 0 && selectedIndex < enumValues.Length)
                    {
                        int ordinalValue = (int)enumValues.GetValue(selectedIndex);

                        IntValueTextBox.Text = ordinalValue.ToString();
                    }
                }
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = ParsValueTextBox.Text;

            if (Enum.TryParse(input, true, out Weekday parsedDay))
            {
                int dayNumber = (int)parsedDay + 1;

                WeekParsedLabel.Text = $"Это день недели({input} = {dayNumber})";
            }

            else
            {
                WeekParsedLabel.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string season = SeasonValueTextBox.Text.ToLower();

            switch (season)
            {
                case "summer":
                    MessageBox.Show("Ура! Солнце!");

                    break;

                case "autumn":
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");

                    break;

                case "winter":
                    MessageBox.Show("Бррр! Холодно!");

                    break;

                case "spring":
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");

                    break;
            }
        }
    }
}
