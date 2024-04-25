using System;

namespace Entities
{
    public interface IDemoraCalculator
    {
        TimeSpan CalcularDemora(Viaje viaje);
    }
}