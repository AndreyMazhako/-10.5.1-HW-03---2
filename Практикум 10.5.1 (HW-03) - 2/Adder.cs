using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_10._5._1__HW_03____2;

// Реализация интерфейса IAdder
class Adder : IAdder
{
    private readonly ILogger _logger; // Внедряем зависимость ILogger

    public Adder(ILogger logger) // Конструктор с параметром ILogger
    {
        _logger = logger;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
