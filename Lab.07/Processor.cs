using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab._05
{
    public class Processor : IComparable
    {

        public string name { get; set; }
        public string manufacturer { get; set; }
        public int core { get; set; }
        public double frequency { get; set; }
        public double tdp { get; set; }
        public double performancePerCore { get; set; }
        public bool multiPrecision { get; set; }
        public bool energySaving { get; set; }

        public string Info()
        {
            return name + ", " + manufacturer;
        }
        public int CompareTo(object obj)
        {
            Processor p = obj as Processor;
            return string.Compare(this.name, p.name);
        }

        public double CalculateTotalPerformance()
        {
            return core * performancePerCore;
        }

        public double yearIncomePerInhabitant
        {
            get
            {
                return CalculateTotalPerformance();
            }

        }
        public Processor()
        {

        }

        public Processor(string Name, string Manufacturer, int Core, double Frequency, double TDP, double PerformancePerCore, bool MP,
                bool ES)
        {
            name = Name;
            manufacturer = Manufacturer;
            core = Core;
            frequency = Frequency;
            tdp = TDP;
            performancePerCore = PerformancePerCore;
            multiPrecision = MP;
            energySaving = ES;
        }
    }
}
