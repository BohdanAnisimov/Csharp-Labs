using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    //Вариант 2, Задание 1
    public class Auto
    {
        public bool wheelAlignment = false;
        public bool painted = false;
        public bool oil = false;
        public bool techInspection = false;
        public bool wheelReplacement = false;
        public bool bodyRepair = false;
    }
    class CTO
    {
        public static void WheelAlignment(Auto auto)
        {
            auto.wheelAlignment = true;
        }
        public static void Painted(Auto auto)
        {
            auto.painted = true;
        }
        public static void Oil(Auto auto)
        {
            auto.oil = true;
        }
        public static void TechInspection(Auto auto)
        {
            auto.techInspection = true;
        }
        public static void WheelReplacement(Auto auto)
        {
            auto.wheelReplacement = true;
        }
        public static void BodyRepair(Auto auto)
        {
            auto.bodyRepair = true;
        }
        public static void Info(Auto auto)
        {
            Console.WriteLine($"Wheel Alignment - {auto.wheelAlignment}");
            Console.WriteLine($"Painted - {auto.painted}");
            Console.WriteLine($"Oil - {auto.oil}");
            Console.WriteLine($"Technical Inspection - {auto.techInspection}");
            Console.WriteLine($"Wheel Replacement - {auto.wheelReplacement}");
            Console.WriteLine($"Body Repair - {auto.bodyRepair}");
        }
    }
    public delegate void CTODelegate(Auto auto);
    class Program
    {
        static void Main(string[] args)
        {
            CTO cto = new CTO();
            Auto auto = new Auto();

            CTODelegate wheelAlignment = new CTODelegate(CTO.WheelAlignment);
            CTODelegate painted = new CTODelegate(CTO.Painted);
            CTODelegate oil = new CTODelegate(CTO.Oil);
            CTODelegate techInspection = new CTODelegate(CTO.TechInspection);
            CTODelegate wheelReplacement = new CTODelegate(CTO.WheelReplacement);
            CTODelegate bodyRepair = new CTODelegate(CTO.BodyRepair);
            CTODelegate info = new CTODelegate(CTO.Info);

            info.Invoke(auto);
            wheelAlignment.Invoke(auto);
            oil.Invoke(auto);
            bodyRepair(auto);
            info(auto);
            Console.ReadKey();
        }
    }
}
