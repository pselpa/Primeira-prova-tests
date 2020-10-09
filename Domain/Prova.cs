using System;
using System.Collections.Generic;

namespace Domain
{
    public class Prova
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
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5, então a aplicação deverá receber 5 números e
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


        public double Exercise6(double[] wageList)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 6, então a aplicação deverá 
            //retornar a média salarial dos funcionários de uma empresa.

            double averageWage = 0;
            double totalWage = 0;
            int counter = 0;

            foreach (var item in wageList)
            {
                if (item > 0)
                {
                    totalWage += item;
                    counter++;
                }
            }
            averageWage = totalWage/counter;
            return averageWage;
        }


        public double Exercise7(int[] userState)        
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 7, então a aplicação deverá receber o código da UF
            //do estado onde nasceram 5 usuários. Retornar a porcentagem de usuários que nasceram em Santa Catarina.
            //(42, SC), \n(11, RO), \n(12, AC), \n(13, AM), \n(14, RR), \n(15, PA), \n(16, AP), \n(17, TO), \n(21, MA), \n(22, PI), \n(23, CE), \n(24, RN), \n(25, PB), \n(26, PE), \n(27, AL), \n(28, SE), \n(29, BA), \n(31, MG), \n(32, ES), \n(33, RJ), \n(35, SP), \n(41, PR), \n(43, RS), \n(50, MS), \n(51, MT), \n(52, GO), \n(53, DF)

            double percent = 0;
            double counter = 0;

            foreach (var item in userState)
            {
                if (item == 42)
                {
                    counter++;
                }
            }
            percent = (counter/5) * 100;
            return percent;
        }


        public string[] Exercise8(string[] morningClass, string[] eveningClass)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 8, então a aplicação deverá receber as listas de
            //alunos das turmas Matutino e Vespertino. Cada turma possui 5 alunos. Ao final retorne apenas os nomes dos alunos que estão
            //estudando em período integral.

            var allDayClass = new string[5];
            int counter = 0;
        
            foreach (var item in morningClass)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (item == eveningClass[i])
                    {
                        allDayClass[counter] = item;
                        counter++;
                    }
                }
            }
            return allDayClass;
        }

        
    }
}