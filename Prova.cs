using System;

namespace second_arrays_list_tests
{
    class Prova
    {
        public double Exercise1(double hoursWork, double minutesWork, double wagePerHour)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1, então a aplicação deverá 
            //receber quantas horas e minutos um funcionário trabalha por dia e retornar o valor/hora de seu serviço.

            double dailyWage = wagePerHour * (hoursWork + (minutesWork/60));
            return dailyWage;

        }
    }
}