using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC.Views
{
    class Display
    {
        public void Input()
        {
            Console.Write("Дай ми поръчаното като сума: ");
            double suma=double.Parse(Console.ReadLine());
            Console.WriteLine("Процент = ");
            double percent=double.Parse(Console.ReadLine());
        }
        public void Output() 
        {
            Console.Write($"Сума на сметката: {tipSum}");
            Console.Write($"Обща сума: {totalSum}");
        }
    }
}
