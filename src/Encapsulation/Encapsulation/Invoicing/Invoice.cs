using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        // Deklarasi atribut private
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;

        // Properti public berisi metode set dan get
        public string PartNumber
        {
            get { return _partNumber; }
            set { _partNumber = value; }
        }
        public string PartDescription
        {
            get { return _partDescription; }
            set { _partDescription = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                // Validasi
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    _quantity = 0;
                }
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                // Validasi
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0.0;
                }
            }
        }

        // Konstuktor
        public Invoice(string partNumber, string partDescription, int quantity, double price)
        {
            _partNumber = partNumber;
            _partDescription = partDescription;
            Quantity = quantity; // Memakai properti utk validasi sesuai aturan
            Price = price; // Memakai properti utk validasi sesuai aturan
        }

        public double GetInvoiceAmount()
        {
            return _quantity * _price;
        }
    }
}