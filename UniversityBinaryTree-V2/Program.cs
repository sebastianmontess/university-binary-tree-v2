using System;

namespace UniversityBinaryTree_V2
{
    class Program
    {
        static void Main(string[] args)
        {

            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.tax = 0.28;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "vicerector financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.tax = 0.23;

            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            contadorPosition.tax = 0.15;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "jefe financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.tax = 0.19;

            Position secFin1Position = new Position();
            secFin1Position.Name = "secretaria financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.tax = 0.13;

            Position secFin2Position = new Position();
            secFin2Position.Name = "secretaria financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.tax = 0.09;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "vicerector academico";
            vicAcadPosition.Salary = 780;
            vicAcadPosition.tax = 0.25;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe Regional";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.tax = 0.18;

            Position secReg1Position = new Position();
            secReg1Position.Name = "secretaria Regional 1";
            secReg1Position.Salary = 400;
            secReg1Position.tax = 0.13;

            Position asist1Position = new Position();
            asist1Position.Name = "asistente 1";
            asist1Position.Salary = 250;
            asist1Position.tax = 0.07;

            Position asist2Position = new Position();
            asist2Position.Name = "asistente 2";
            asist2Position.Salary = 170;
            asist2Position.tax = 0.06;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.tax = 0.04;

            Position secReg2Position = new Position();
            secReg2Position.Name = "secretaria Regional 2";
            secReg2Position.Salary = 360;
            secReg2Position.tax = 0.1;


            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);

            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");

            universityTree.LongestSalary(universityTree.Root);
            float LongestSalary = universityTree.getLongestSal();
            Console.WriteLine($"Longest Salary: {LongestSalary}");

            float SalaryAverage = universityTree.SalaryAverage();
            Console.WriteLine($"Salary Average: {SalaryAverage}");

            
            Console.WriteLine("write position here:");
            string pos = Console.ReadLine();
            float SalaryPosition = universityTree.SalaryPosition(universityTree.Root, pos);
            if (SalaryPosition == 0)
            {
                Console.WriteLine("wrong name");

            }
            else
            {
                Console.WriteLine($"Salary position: {SalaryPosition}");
            }
            
            double TotalTaxes = universityTree.TotalTaxes(universityTree.Root);
            Console.WriteLine($"Total Taxes: {TotalTaxes}");

            Console.ReadLine();




        }
    }
}
