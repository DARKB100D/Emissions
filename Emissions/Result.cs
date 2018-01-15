using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissions
{
    struct Result
    {
        double emission;
        double GrossYear;
        double GrossSecond;
        double SpecificYear;
        double SpecificSecond;
        Result(double y, double s, double q, double e) {
            emission = e;
            GrossYear = e;
            GrossSecond = e;
            SpecificYear = e;
            SpecificSecond = e;
        }
    }
}
