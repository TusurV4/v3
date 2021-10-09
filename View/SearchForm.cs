using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс поиска информации.
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Делегат поиска транспорта.
        /// </summary>
        private readonly SearchDelegate _searchDelegate = null;

        /// <summary>
        /// Конструктор класса SearchForm.
        /// </summary>
        /// <param name="searchDelegate">Делегат поиска 
        /// транспортного средства.</param>
        public SearchForm(SearchDelegate searchDelegate)
        {
            InitializeComponent();
            _searchDelegate = searchDelegate;
            ConsumedFuelTextBox.KeyPress += Check.CheckInput;
            TransportNameComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие при выборе транспорта.
        /// </summary>
        private void TransportNameComboBox_SelectedIndexChanged(object
            sender, EventArgs e)
        {
            ConsumedFuelTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Событие при нажатии на кнопку отмена.
        /// </summary>
        private void ExitFindButton_Click(object sender, EventArgs e)
        {
            Hide();
            Transport transport = new Transport
            {
                TransportName = "",
                ConsumedFuel = null
            };
            _searchDelegate(transport);
        }

        /// <summary>
        /// Событие при нажатии на кнопку найти.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Hide();
            Transport transport = new Transport
            {
                TransportName = TransportNameComboBox.Text.ToString()
            };
            if (!string.IsNullOrEmpty(ConsumedFuelTextBox.Text))
                transport.ConsumedFuel = Convert
                        .ToDouble(ConsumedFuelTextBox.Text);
            else
                transport.ConsumedFuel = null;
            _searchDelegate(transport);
        }
    }
}