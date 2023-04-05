using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Practice13_Zadanie3
{
    public partial class Form1 : Form
    {
        SortedList<string, MeasurementDevice> data = new SortedList<string, MeasurementDevice>
            {
                {"1", new MeasurementDevice{Name = "Мульмиметр", Type = "Цифровой", Manufacturer = "Яндекс", Accuracy = 0.5, Price = 5000}},
                {"2", new MeasurementDevice{Name = "Осциллограф", Type = "Аналоговый", Manufacturer = "Google", Accuracy = 2.0, Price = 10000}},
                {"3", new MeasurementDevice{Name = "Электронный вольметр", Type = "Цифровой", Manufacturer = "Apple", Accuracy = 0.1, Price = 3500}},
                {"4", new MeasurementDevice{Name = "Измерительный трансформатор", Type = "Аналоговый", Manufacturer = "Apple", Accuracy = 0.01, Price = 14000}}
            };
        private void InitDataGridView()
        {
            dataGridView1.Columns.Add("Key", "Ключ");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Type", "Тип");
            dataGridView1.Columns.Add("Manufacturer", "Производитель");
            dataGridView1.Columns.Add("Accuracy", "Точность");
            dataGridView1.Columns.Add("Price", "Цена, руб.");
            int key = 1;
            foreach(var item in data)
            {
                dataGridView1.Rows.Add(key, item.Value.Name, item.Value.Type, item.Value.Manufacturer, item.Value.Accuracy, item.Value.Price);
                key++;
            }
        }
        private string CheckString(TextBox tb)
        {
            bool test = false;
            if (tb.TextLength == 0)
            {

                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            else
            {
                foreach (char c in tb.Text)
                {
                    if (!char.IsLetter(c))
                        test = true;

                }
                if (test == true)
                {
                    tb.BackColor = Color.LightCoral;
                    tb.Text = "0";
                }
                else
                    return tb.Text;
            }
            return tb.Text;
        }
        static double CheckDoubleNumber(TextBox tb)
        {

            try
            {
                if (Convert.ToDouble(tb.Text) > 0)
                {
                    return Convert.ToDouble(tb.Text);
                }
            }
            catch (Exception)
            {
                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            return Convert.ToDouble(tb.Text);
        }
        private int CheckKey(TextBox tb)
        {

            try
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells["Key"].Value != null && row.Cells["Key"].Value.ToString() == tb.Text)
                    {
                        tb.BackColor = Color.LightCoral;
                        tb.Text = "0";
                    }
                }
            }
            catch (Exception)
            {
                tb.BackColor = Color.LightCoral;
                tb.Text = "0";
            }
            return int.Parse(tb.Text);
        }
        private void AddFile()
        {
            StreamWriter sw = File.CreateText("device.txt");
            foreach(var sr in data)
            {
                sw.WriteLine($"{sr.Key};{sr.Value.Name};{sr.Value.Type};{sr.Value.Manufacturer};{sr.Value.Accuracy};{sr.Value.Price} ");
            }
            sw.Close();
        }
        private void LoadFromFile()
        {
            data.Clear();
            using (StreamReader sr = new StreamReader("device.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');
                    string key = fields[0];
                    string name = fields[1];
                    string type = fields[2];
                    string manufacturer = fields[3];
                    double accuracy = double.Parse(fields[4]);
                    double price = double.Parse(fields[5]);
                    data.Add(key, new MeasurementDevice(name, type, manufacturer, accuracy, price));
                }
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            LoadFromFile();
            InitDataGridView();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNewDevice_Click(object sender, EventArgs e)
        {
            MeasurementDevice measurementDevice = new MeasurementDevice
            {
                Name = CheckString(textBoxName),
                Type = CheckString(textBoxType),
                Manufacturer = CheckString(textBoxManufacturer),
                Accuracy = CheckDoubleNumber(textBoxAccuracy),
                Price = CheckDoubleNumber(textBoxPrice)
            };
            int key = CheckKey(textBoxKey);
            if(textBoxName.Text == "0" || textBoxType.Text == "0" || textBoxManufacturer.Text == "0" || textBoxAccuracy.Text == "0" || textBoxPrice.Text == "0" || textBoxKey.Text == "0")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data.Add(key.ToString(), measurementDevice);
                dataGridView1.Rows.Add(key, measurementDevice.Name, measurementDevice.Type, measurementDevice.Manufacturer, measurementDevice.Accuracy, measurementDevice.Price);
                AddFile();
                textBoxKey.BackColor = Color.White;
                textBoxName.BackColor = Color.White;
                textBoxType.BackColor = Color.White;
                textBoxManufacturer.BackColor = Color.White;
                textBoxAccuracy.BackColor = Color.White;
                textBoxPrice.BackColor = Color.White;

            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string key = selectedRow.Cells[0].Value.ToString();
                data.Remove(key);
                dataGridView1.Rows.RemoveAt(selectedRow.Index);
                AddFile();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            textBox1.Visible = true;
            button_Search.Visible = true;

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string filter = textBox1.Text.Trim();

            // Получение имени выбранной колонки из RadioButton
            string columnName = "";
            if (radioButtonName.Checked) columnName = "Name";
            else if (radioButtonType.Checked) columnName = "Type";
            else if (radioButtonManufacturer.Checked) columnName = "Manufacturer";
            else if (radioButtonAccuracy.Checked) columnName = "Accuracy";
            else if (radioButtonPrice.Checked) columnName = "Price";

            // Фильтрация элементов
            List<MeasurementDevice> filteredDevices = new List<MeasurementDevice>();
            foreach (MeasurementDevice device in data.Values)
            {
                if (columnName == "Name")
                {
                    if (device.Name.ToString().Contains(filter))
                        filteredDevices.Add(device);
                }
                else if (columnName == "Type")
                {
                    if (device.Type.Contains(filter))
                        filteredDevices.Add(device);
                }
                else if (columnName == "Manufacturer")
                {
                    if (device.Manufacturer.Contains(filter))
                        filteredDevices.Add(device);
                }
                else if (columnName == "Accuracy")
                {
                    if (double.TryParse(filter, out double filterValue))
                    {
                        if (device.Accuracy >= filterValue)
                            filteredDevices.Add(device);
                    }
                }
                else if (columnName == "Price")
                {
                    if (double.TryParse(filter, out double filterValue))
                    {
                        if (device.Price >= filterValue)
                            filteredDevices.Add(device);
                    }
                }
            }

            // Очистка DataGridView и добавление отфильтрованных элементов
            dataGridView1.Rows.Clear();
            foreach (MeasurementDevice device in filteredDevices)
            {
                dataGridView1.Rows.Add(device.Name, device.Type, device.Manufacturer, device.Accuracy, device.Price);
            }

            button_Search.Visible = false;
            buttonBack.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoadFromFile();
            InitDataGridView();
            groupBox1.Visible = false;
            textBox1.Visible = false;
            buttonBack.Visible = false;
        }
    }
}
