using System;

namespace Entities.Entrega
{
    public class DemoraCalculatorWithoutStops : IDemoraCalculator
    {
        private readonly IDistanceCalculatorAdapter distanceCalculatorAdapter;

        public DemoraCalculatorWithoutStops(IDistanceCalculatorAdapter distanceCalculatorAdapter)
        {
            this.distanceCalculatorAdapter = distanceCalculatorAdapter;
        }

        public TimeSpan CalcularDemora(Viaje viaje)
        {
            throw new NotImplementedException();
        }
    }
}