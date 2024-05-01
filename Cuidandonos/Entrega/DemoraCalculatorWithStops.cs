using System;
using System.Collections.Generic;

namespace Entities.Entrega
{
    public class DemoraCalculatorWithStops : IDemoraCalculator
    {
        private readonly IDistanceCalculatorAdapter distanceCalculatorAdapter;

        public DemoraCalculatorWithStops(IDistanceCalculatorAdapter distanceCalculatorAdapter)
        {
            this.distanceCalculatorAdapter = distanceCalculatorAdapter;
        }

        public TimeSpan CalcularDemora(Viaje viaje)
        {
            throw new NotImplementedException();
        }
    }
}