﻿using System.Collections.Generic;
using Composition.Entities.Enums;

namespace Composition.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set;  }
        public double  BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        //construtores
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //implementar método

        //adicionar um contrato
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //remover contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                     if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum; 
        }



    }
}
