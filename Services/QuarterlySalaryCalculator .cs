using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueteInjectionDependance
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        public Double CalculateSalary(Double yearlyAmount)
        {
            return yearlyAmount / 4;
        }
    }


}
