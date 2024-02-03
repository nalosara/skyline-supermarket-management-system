using supermarket_management_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Impl
{
    internal class CashRegisterImpl : ICashRegister
    {
        private readonly CashRegister CashRegister;
        public CashRegisterImpl(CashRegister cashRegister) 
        {
            CashRegister = cashRegister;
        }
        public void AddCash(double cashAmount)
        {
            CashRegister.TotalCash += cashAmount;
            Console.WriteLine($"Added ${cashAmount} to the cash register. Total cash: ${CashRegister.TotalCash}");
        }
    }
}
