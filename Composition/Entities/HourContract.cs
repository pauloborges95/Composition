﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Entities
{
    class HourContract
    {
        public DateTime Date{ get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //construtores
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //método
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

       
    }
}
