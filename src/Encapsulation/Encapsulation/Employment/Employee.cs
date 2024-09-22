using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Employment
{
    public class Employee
    {
        // Deklarasi atribut private
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        // Properti public berisi metode set dan get
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                // Validasi
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _firstName = value;
                }
                else
                {
                    _firstName = "Unknown";
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                // Validasi
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
                else
                {
                    _lastName = "Unknown";
                }
            }
        }
        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                // Validasi
                if (value >= 0)
                {
                    _monthlySalary = value;
                }
            }
        }

        // Konstruktor memakai properti utk validasi sesuai aturan
        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        // Metode utk menaikkan monthly salary max 20%
        public void RaiseSalary(int raisePercentage)
        {
            // Validasi
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary += (_monthlySalary * raisePercentage / 100.0);
            }
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12; // Gaji bulanan disetahunkan
        }
    }
}