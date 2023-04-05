using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_Zadanie3
{
    class MeasurementDevice
    {
        private string name;
        private string type;
        private string manufacturer;
        private double accuracy;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public double Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public MeasurementDevice(string name, string type, string manufacturer, double accuracy, double price)
        {
            this.name = name;
            this.type = type;
            this.manufacturer = manufacturer;
            this.accuracy = accuracy;
            this.price = price;
        }
        public MeasurementDevice()
        {

        }

    }
}
