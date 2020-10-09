using Domain;
using Xunit;

namespace Tests
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


        [Theory]
        [InlineData(new double[3]{500, 1000, 1500}, 1000)]
        [InlineData(new double[4]{800, 750, 1100, 700}, 837.50)]
        [InlineData(new double[3]{-25, 2000, 1500}, 1750)]
        public void should_return_the_average_wage_of_a_group_of_workers(double[] wageList, double expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            var returnedValue = exercises.Exercise6(wageList);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new int[5]{42, 11, 17, 22, 42}, 40)]
        [InlineData(new int[5]{17, 25, 33, 61, 12}, 0)]
        [InlineData(new int[5]{14, 25, 42, 18, 45}, 20)]
        [InlineData(new int[5]{17, 42, 42, 42, 31}, 60)]
        public void should_return_the_percentage_of_people_from_SC(int[] userState, double expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            var returnedValue = exercises.Exercise7(userState);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new string[5]{"Ana", "Josi", "Cláudia", "Fernanda", "Mabel"}, new string[5]{"Mabel", "Josi", "Rafa", "Cláudia", "Clara"}, new string[5]{"Josi", "Cláudia", "Mabel", null, null})]
        public void should_return_the_list_of_students_who_study_all_day(string[] morningClass, string[] eveningClass, string[] expected)
        {
            // Dado / Setup
            var exercises = new Prova();

            // Quando / Ação
            var returnedValue = exercises.Exercise8(morningClass, eveningClass);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

    }
}
