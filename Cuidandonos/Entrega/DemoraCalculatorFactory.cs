using System;

namespace Entities.Entrega
{
    public class DemoraCalculatorFactory
    {
        private readonly IDistanceCalculatorAdapter distanceCalculatorAdapter;

        public DemoraCalculatorFactory(IDistanceCalculatorAdapter distanceCalculatorAdapter)
        {
            this.distanceCalculatorAdapter = distanceCalculatorAdapter;
        }

        public IDemoraCalculator GetDemoraCalculatorByTripType(TripType viaje) 
        {
            switch (viaje) 
            {
                case TripType.WithoutStops: return new DemoraCalculatorWithoutStops(distanceCalculatorAdapter);
                case TripType.WithStops: return new DemoraCalculatorWithStops(distanceCalculatorAdapter);
                default: throw new NotImplementedException();
            }
        }
    }
}