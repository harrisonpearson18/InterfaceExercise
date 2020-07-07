using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Logo { get; set; }



        public void CompanyInfo()
        {
            Console.WriteLine($"Logo: {Logo}");

        }

    }
}
