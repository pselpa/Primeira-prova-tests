using System;
using System.Collections.Generic;
using Xunit;

namespace Primeira_prova
{
    public class ProvaTests
    {
        [Theory]
        [InlineData(8, 0, 5, 40)]
        [InlineData(9, 30, 10, 95)]
        [InlineData(4, 0, 6, 24)]
        public void should_return_the_daily_wage_of_a_worker_based_on_how_many_hours_they_work(double hoursWork, double minutesWork, double wagePerHour, double expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            double returnedValue = exercises.Exercise1(hoursWork, minutesWork, wagePerHour);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new string[5]{"S","w","o","r","d"}, "Sword")]
        [InlineData(new string[5]{"A","r","m","o","r"}, "Armor")]
        [InlineData(new string[5]{"S","t","a","f","f"}, "Staff")]
        public void should_return_a_word_from_a_list_of_strings(string[] word, string expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            var returnedValue = exercises.Exercise2(word);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        // ************** TESTAR O 3 DEPOIS **************


        [Theory]
        [InlineData(2016, false)]
        [InlineData(1992, true)]
        [InlineData(1858, true)]
        [InlineData(2074, false)]
        public void should_return_if_a_person_is_over_aged(int year, bool expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            bool returnedValue = exercises.Exercise4(year);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new object[5]{3, null, 5, 10, null}, new object[3]{3, 5, 10})]
        public void should_return_the_valid_numbers_of_a_list(object[] array, object[] expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            var returnedValue = exercises.Exercise5(array);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        
    }
}
