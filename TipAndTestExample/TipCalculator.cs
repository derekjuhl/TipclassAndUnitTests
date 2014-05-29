using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipAndTestExample
{
    public class TipCalculator
    {
        private double Amount { get; set; }
        private const double TAX = .095;
        private double tipPercent;

        public TipCalculator()
        {
            Amount=0;
            TipPercent=0;
        }
        public TipCalculator(double amt, double percent)
        {
            Amount = amt;
            TipPercent = percent;
        }

        public double TipPercent
        {
            get { return tipPercent; }
            set {
                if (value > 1)
                {
                    tipPercent = value / 100;
                }
                else
                {
                    tipPercent = value;
                }
            }
        }

        public double CalculateTip()
        {
            return Amount * TipPercent;
        }

        public double CalculateTax()
        {
            return Amount * TAX;
        }

        public double CalculateTotal()
        {
            return Amount + CalculateTip() + CalculateTax();
        }
    }
}
