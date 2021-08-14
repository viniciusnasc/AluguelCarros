using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Services
{
    class PaypalService : ITax
    {
        public double Tax(int monthQtd, double value)
        {
            return ((value*0.01*monthQtd)+value)*0.02 + (value * 0.01 * monthQtd) + value;
        }
    }
}
