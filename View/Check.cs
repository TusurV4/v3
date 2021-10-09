using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс для проверки вводимых значений.
    /// </summary>
    public static class Check
    {
        /// <summary>
        /// Метод проверки достоверности ввода значений.
        /// </summary>
        public static void CheckInput(object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                         && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
            if ((sender as TextBox).Text.Length == 0)
                if (e.KeyChar == ',')
                    e.Handled = true;
        }
    }
}