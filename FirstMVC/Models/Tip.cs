using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FirstMVC.Models
{
    public class Tip
    {
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double percent;

        public double Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;
                }
                else
                {
                    this.percent = value;
                }

            }
        }

        public double CalculateTotal()
        {
            return this.Amount + CalculateTip();
        }
        public double CalculateTip()
        {
            return (this.Percent * this.Amount);
        }
        public Tip(double suma, double percent)
        {
            Amount = suma;
            Percent=percent;
        }
    }
}

