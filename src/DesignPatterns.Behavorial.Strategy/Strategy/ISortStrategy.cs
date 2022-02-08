using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Strategy.Strategy
{
    public interface ISortStrategy
    {
        List<string> Sort(List<string> list);
    }
}
