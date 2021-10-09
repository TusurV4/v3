#define Debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Model;

namespace View
{
    /// <summary>
    /// Класс добавления информации о транспорте.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Коллекция, хранящая информацию о транспорте. 
        /// </summary>
        private readonly List<Transport> _transport;

        /// <summary>
        /// Делегат обновления данных в TransportDataGridView.
        /// </summary>
        private readonly UpdateTransport _updateTransport;

        /// <summary>
        /// Конструктор класса AddForm.
        /// Изменение комментария к конструктору 
        /// AddForm для выполнения lr3.
        /// </summary>
        /// <param name="transport">Транспортное средство.</param>
        /// <param name="updateTransport">Делегат
        /// обновления информации.</param>
        public AddForm(List<Transport> transport,
            UpdateTransport updateTransport)
        {
            InitializeComponent();
            _transport = transport;
            _updateTransport = updateTransport;
            TransportNameComboBox.SelectedIndex = 0;
#if Release
            this.RandomValueButton.Visible = false;
#elif Debug
            this.RandomValueButton.Visible = true;
#endif
        }

        /// <summary>
        /// Событие при загрузке формы AddForm.
        /// </summary>
        private void AddForm_Load(object sender, EventArgs e)
        {
            TransportNameComboBox_SelectedIndexChanged(sender, e);

            AddTextBox1.KeyPress += Check.CheckInput;
            AddTextBox2.KeyPress += Check.CheckInput;
            AddTextBox3.KeyPress += Check.CheckInput;
        }

        /// <summary>
        /// Событие выбора транспорта из выпадающего списка.
        /// </summary>
        private void TransportNameComboBox_SelectedIndexChanged(object
            sender, EventArgs e)
        {
            AddTextBox1.Text = string.Empty;
            AddTextBox2.Text = string.Empty;
            AddTextBox3.Text = string.Empty;

            switch (TransportNameComboBox.SelectedIndex)
            {
                case 0:
                    AddItemLabel1.Visible = true;
                    AddItemLabel2.Visible = true;
                    AddItemLabel3.Visible = false;

                    AddItemLabel1.Text = "Расход топлива";
                    AddItemLabel2.Text = "Расстояние";

                    AddTextBox1.Visible = true;
                    AddTextBox2.Visible = true;
                    AddTextBox3.Visible = false;
                    break;
                case 1:
                    AddItemLabel1.Visible = true;
                    AddItemLabel2.Visible = true;
                    AddItemLabel3.Visible = true;

                    AddItemLabel1.Text = "Расход топлива";
                    AddItemLabel2.Text = "Общее расстояние";
                    AddItemLabel3.Text = "Расстояние на электродвигателе";

                    AddTextBox1.Visible = true;
                    AddTextBox2.Visible = true;
                    AddTextBox3.Visible = true;

                    break;
                case 2:
                    AddItemLabel1.Visible = true;
                    AddItemLabel2.Visible = true;
                    AddItemLabel3.Visible = false;

                    AddItemLabel1.Text = "Расход топлива";
                    AddItemLabel2.Text = "Время полёта";

                    AddTextBox1.Visible = true;
                    AddTextBox2.Visible = true;
                    AddTextBox3.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку отмена.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (_transport.Count > 0)
                _updateTransport();
        }

        /// <summary>
        /// Событие при нажатии на кнопку Oк
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;
            try
            {
                switch (TransportNameComboBox.SelectedIndex)
                {
                    case 0:
                        if (AddTextBox1.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "расход топлива машины.\n";
                        }
                        if (AddTextBox2.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "расстояние пройденное машиной.\n";
                        }
                        if (errorMessage == string.Empty)
                        {
                            AbstractTransport automobile =
                                new Automobile(Convert
                                .ToDouble(AddTextBox2.Text),
                                Convert.ToDouble(AddTextBox1.Text));
                            AddAbstractTransport(automobile);
                        }
                        break;
                    case 1:
                        if (AddTextBox1.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "расход топлива машины-гибрида.\n";
                        }
                        if (AddTextBox2.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "общее расстояние пройдённое " +
                                "машиной-гибридом.\n";
                        }
                        if (AddTextBox3.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "расстояние пройденное машиной-гибридом " +
                                "на электрическом двигателе.\n";
                        }
                        if (Convert.ToDouble(AddTextBox2.Text)
                            < Convert.ToDouble(AddTextBox3.Text))
                        {
                            errorMessage += "Общее расстояние должно " +
                                "быть больше или равно " +
                                "расстоянию пройденному " +
                                "на электрическом двигателе.\n";
                        }
                        if (errorMessage == string.Empty)
                        {
                            AbstractTransport hybrid = new HybridCar(
                                Convert.ToDouble(AddTextBox2.Text),
                                Convert.ToDouble(AddTextBox3.Text),
                                Convert.ToDouble(AddTextBox1.Text));
                            AddAbstractTransport(hybrid);
                        }
                        break;
                    case 2:
                        if (AddTextBox1.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "расход топлива вертолёта.\n";
                        }
                        if (AddTextBox2.Text == string.Empty)
                        {
                            errorMessage += "Необходимо ввести " +
                                "время полёта вертолёта.\n";
                        }
                        if (errorMessage == string.Empty)
                        {
                            AbstractTransport helicopter = new
                                Helicopter(Convert
                                .ToDouble(AddTextBox2.Text),
                                Convert.ToDouble(AddTextBox1.Text));
                            AddAbstractTransport(helicopter);
                        }
                        break;
                }

                if (errorMessage != string.Empty)
                {
                    MessageBox.Show(errorMessage, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод добавления транспорта.
        /// </summary>
        /// <param name="abstractTransport">Информация
        /// о транспорте.</param>
        private void AddAbstractTransport(AbstractTransport
            abstractTransport)
        {
            _transport.Add(new Transport
            {
                TransportName = TransportNameComboBox
                .SelectedItem.ToString(),
                ConsumedFuel = Math.Round(abstractTransport
                .ConsumedFuel, 3)
            });
        }

        /// <summary>
        /// Событие при нажатии на кнопку случайное значение.
        /// </summary>
        private void RandomValueButton_Click(object sender,
            EventArgs e)
        {
            Random random = new Random();
            int ramdomNumber = random.Next(0, 3);
            TransportNameComboBox.SelectedIndex = ramdomNumber;
            Thread.Sleep(25);
            switch (TransportNameComboBox.SelectedIndex)
            {
                case 0:
                    AddTextBox1.Text = random.Next(1,
                        Automobile.maxConsumedConsumption).ToString();
                    AddTextBox2.Text = random.Next(1,
                        Automobile.maxCoveredDistance).ToString();
                    break;
                case 1:
                    AddTextBox1.Text = random.Next(1,
                        HybridCar.maxConsumedConsumption)
                        .ToString();
                    AddTextBox2.Text = random.Next(1,
                        HybridCar.maxTotalCoveredDistance - 1)
                        .ToString();
                    AddTextBox3.Text = random.Next(1,
                        HybridCar.maxCoreredDistanceElectricMotor)
                        .ToString();
                    if (Convert.ToDouble(AddTextBox2.Text)
                        <= Convert.ToDouble(AddTextBox3.Text))
                    {
                        string tempValue = AddTextBox2.Text;
                        AddTextBox2.Text = AddTextBox3.Text;
                        AddTextBox3.Text = tempValue;
                    }
                    break;
                case 2:
                    AddTextBox1.Text = random.Next(1,
                        Helicopter.maxConsumedConsumption)
                        .ToString();
                    AddTextBox2.Text = random.Next(1,
                        Helicopter.maxTimeFligth)
                        .ToString();
                    break;
            }
        }
    }
}