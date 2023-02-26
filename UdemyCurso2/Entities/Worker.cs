using UdemyCurso2.Entities.Enums;
using System.Collections.Generic;

namespace UdemyCurso2.Entities
{
    internal class Worker
    {
        public string Name { get; private set; }
        public Workerlevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public Departament Departament { get; private set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker(string name, Workerlevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
