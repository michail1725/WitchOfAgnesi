using System;

namespace WitchOfAgnesi
{
    public class FuncCalc
    {
        public double aNum;
        public double Calculate(double xNum) {
            return Math.Pow(aNum,3)/(Math.Pow(aNum, 2)+ Math.Pow(xNum, 2));
        }
    }
}
