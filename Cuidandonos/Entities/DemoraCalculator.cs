using System;

namespace Entities
{
    class DemoraCalculator : IDemoraCalculator
    {
        private readonly IDistanceCalculatorAdapter distanceCalculatorAdapter;

        public DemoraCalculator(IDistanceCalculatorAdapter distanceCalculatorAdapter)
        {
            this.distanceCalculatorAdapter = distanceCalculatorAdapter;
        }

        public TimeSpan CalcularDemora(Viaje viaje)
        {
            throw new NotImplementedException();
        }
    }
}
