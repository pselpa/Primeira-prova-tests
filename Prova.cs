using System;
using System.Collections.Generic;

namespace Primeira_prova
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


        public string Exercise2(string[] word)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2, então a 
            //aplicação deverá receber uma palavra uma letra por vez. Retornar a palavra inteira

            string resultWord = "";

            foreach (var item in word)
            {
                resultWord += item;
            }
            return resultWord;
        }


        // ************** TESTAR O 3 DEPOIS **************

        public bool Exercise4(int year)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4, então a aplicação
            //deverá receber o ano de nascimento do usuário e retornar se ele é ou não maior de idade.
            bool answer = false;

            if (2020 - year >= 18)
            {
                answer = true;
            }
            return answer;
        }


        public List<object> Exercise5(object[] array)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4, então a aplicação deverá receber 5 números e
            //armazenar em um array. Se houver um valor inválido, armazenar “null” no índice. Ao final, imprimir apenas os números válidos.

            var resultList = new List<object>{};

            foreach (var item in array)
            {
               if (item != null)
               {
                    resultList.Add(item);
               }
            }
            return resultList;
        }
    }
}