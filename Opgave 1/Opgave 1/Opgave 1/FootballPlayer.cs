using System;
using System.Dynamic;

namespace Opgave_1
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private double _price;
        private int _shirtNumber;

        public int Id
        {
            get => _id;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length <= 4)
                {
                    throw new ArgumentOutOfRangeException("Name must be longer than or equal to 4 ");
                }

                _name = value;
            }

        }

        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _shirtNumber = value;
            }
        }
    }
}
