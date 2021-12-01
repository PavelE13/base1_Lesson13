using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите адрес постройки:");
            string adress = Console.ReadLine();
            Console.Write(" Введите длинну здания: ");
            byte length = Convert.ToByte(Console.ReadLine());
            Console.Write(" Введите ширину здания: ");
            byte width = Convert.ToByte(Console.ReadLine());
            Console.Write(" Введите высоту здания: ");
            byte heigth = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("*****************************************");
            Building ValleyHill = new Building(adress, length, width, heigth);
            ValleyHill.Print(adress, length, width, heigth);
            Console.WriteLine("*****************************************");
            Console.Write(" Введите этажность постройки: ");
            byte floor = Convert.ToByte(Console.ReadLine());
            MultiBuilding ValleyHillfloor = new MultiBuilding(ValleyHill.adress, ValleyHill.length, ValleyHill.width, ValleyHill.heigth, floor);
            ValleyHillfloor.Print(adress, length, width, heigth, floor);
            Console.ReadKey();
        }
    }
    public class Building
    {
        public string adress;
        public double length;
        public double width;
        public byte heigth;
        string Adress { get; set; }
        double Length { get; set; }
        double Width { get; set; }
        byte Heigth { get; set; }

        public Building(string adress, double length, double width, byte heigth) // Конструктор
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
        }
        public void Print(string adress, double length, double width, byte heigth)
        {
            Console.WriteLine(" Адресс объекта: {0}", adress);
            Console.WriteLine(" Длина здания: {0}", length);
            Console.WriteLine(" Ширина здания: {0}", width);
            Console.WriteLine(" Высота здания: {0}", heigth);
        }
    }
    sealed class MultiBuilding:Building
    {
        byte floor;
        byte Floor { get; set; }
        public MultiBuilding(string adress, double length, double width, byte heigth, byte floor): base(adress, length, width, heigth)
        {
            base.adress = adress;
            base.length = length;
            base.width = width;
            base.adress = adress;
            base.heigth = heigth;
            this.Floor = floor;
        }
        public void Print(string adress, double length, double width, byte heigth, byte floor)
        {
            base.Print(adress, length, width, heigth);
            Console.WriteLine(" Высота здания: {0}", floor);
        }
    }
}
