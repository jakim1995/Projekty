using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierska.Helpers
{
    class WeatherCalculator
    {
        private enum ConstName
        {
            A,
            B,
            C
        }
        public double CalculateVectorSpeed(double u, double v)
        {
            return Math.Sqrt(Math.Pow(u, 2) + Math.Pow(v, 2));
        }

        public double CalculateWindVector(double u, double v)
        {
            return 180 / Math.PI * Math.Atan2(u, v);
        }

        public double CalculateWindSpeedByHeight(double height, double windSpeed, double alpha, double mainHeight)
        {
            return windSpeed * Math.Pow(height / mainHeight, alpha);
        }

        public double ConversionOfWindSpeedIntoPower(double windSpeed, double parameterPr, double parameterVci, double parameterVr, double parameterVco)
        {
            if(windSpeed >= parameterVci && windSpeed <= parameterVr)
            {
                return parameterPr * (CalcConst(ConstName.A, parameterPr, parameterVci, parameterVr, parameterVco) + CalcConst(ConstName.B, parameterPr, parameterVci, parameterVr, parameterVco) 
                                        * windSpeed + CalcConst(ConstName.C, parameterPr, parameterVci, parameterVr, parameterVco) * Math.Pow(windSpeed, 2));
            }
            else if (windSpeed >= parameterVr && windSpeed <= parameterVco)
            {
                return parameterPr;
            }
            else
            {
                return 0;
            }
        }

        private double CalcConst(ConstName constName, double parameterPr, double parameterVci, double parameterVr, double parameterVco)
        {
            switch (constName)
            {
                case ConstName.A:
                    return 1 / Math.Pow(parameterVci - parameterVr, 2) * (parameterVci * (parameterVci + parameterVr) - 4 * parameterVci * parameterVr * Math.Pow((parameterVci + parameterVr) / (2 * parameterVr), 3));
                case ConstName.B:
                    return 1 / Math.Pow(parameterVci - parameterVr, 2) * (4 * (parameterVci + parameterVr) * Math.Pow((parameterVci + parameterVr) / (2 * parameterVr), 3) - (3 * parameterVci + parameterVr));
                case ConstName.C:
                    return 1 / Math.Pow(parameterVci - parameterVr, 2) * (2 - 4 * Math.Pow((parameterVci + parameterVr) / (2 * parameterVr), 3));
                default:
                    return 0;
            }
        }

    }
}
