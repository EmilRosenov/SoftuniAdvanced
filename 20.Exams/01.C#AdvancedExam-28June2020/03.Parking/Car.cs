﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        private string manufacturer;
        private string model;
        private int year;

        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }


        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year})";
        }
    }
}
