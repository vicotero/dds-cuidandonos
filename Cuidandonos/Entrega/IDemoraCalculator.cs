using System;
using System.Collections.Generic;

namespace Entities.Entrega
{
    public interface IDemoraCalculator
    {
        TimeSpan CalcularDemora(Viaje viaje);
    }
}