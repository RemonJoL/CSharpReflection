using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReflection
{
    public class Car
    {
        private readonly string _make;
        private readonly string _model;
        private readonly string _registration;
        private readonly int _year;
        private readonly int _currentValue;

        public Car(string make, string model, string registration, int year, int currentValue )
        {
            _make = make;
            _model = model;
            _registration = registration;
            _year = year;
            _currentValue = currentValue;
        }

        public string Make()
        {
            return _make;
        }

        public string Model()
        {
            return _model;
        }

        public string Registration()
        {
            return _registration;
        }

        public int CurrentValue()
        {
            return _currentValue;
        }

        public int Year()
        {
            return _year;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\n\nRegistration: {2}\nYear of Registration: {3}\nCurrently Valued at: {4}\n--------------------------\n", _make, _model, _registration, _year,_currentValue);

        }
    }
}
