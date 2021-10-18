using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueteInjectionDependance
{
  
        [Microsoft.AspNetCore.Components.Route("api/[controller]")]

        public class SalaryController

        {

            private ISalaryCalculator _calculator;


            public SalaryController(ISalaryCalculator injectedCalculator)

            {

                _calculator = injectedCalculator;

            }


            [HttpGet("yearlyAmount")]

        public Double Get(Double yearlyAmount)

        {

            return = _calculator.CalculateSalary(yearlyAmount);

             

        }

    }
}

