using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Interfaces
{
    public interface IBackEndProgrammer
    {
        public void ImplementBackEnd();
        public void ConnectCodeDatabase() {
            Console.WriteLine("Connecting to database...");
        }
    }
}