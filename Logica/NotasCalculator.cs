
namespace Logica
{
    public class NotasCalculator
    {
        public static double CalcularPromedio(int Num1, int Num2, int Num3)
        {
            return (Num1 + Num2 + Num3) / 3.0;
            //Realizado solid
        }

        public static string DeterminarResultado(double promedio)
        {
            return promedio >= 3 ? "Ganó" : "Perdió";
        }
    }
}
