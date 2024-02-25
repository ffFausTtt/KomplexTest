using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using test;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calcBonusesVarOne_True() // проверяем, что количество баллов = количеству правильных вариантов
        {
            int expected = 14; // количество баллов
             string[] otv = new string[17];
            // string[] otv = new string[] { "Pizza", "could read in English", "every week", "write a book", "True", "False", "True", "Pizza", "book", "interesting", "happy", "better", "-", "wrote", "was", "Does" };
            otv[0] = "Pizza";
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otv);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void calcBonusesVarOne_False() // проверяем, что количество баллов != количеству правильных вариантов
        {
            int expected = 22; // количество баллов
            string[] otv = new string[17];
            otv[0] = "Pizza";
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otv);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void calcBonusesVarOne_IsTrue() // проверяем, что количество баллов == количеству правильных вариантов
        {
            int expected = 14; // количество баллов
            string[] otv = new string[17];
            otv[0] = "Pizza";
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otv);
            Assert.IsTrue(expected == actual);
        }
        [TestMethod]
        public void calcBonusesVarOne_IsFalse() // проверяем, что количество баллов != количеству правильных вариантов
        {
            int expected = 14; // количество баллов
            string[] otv = new string[17];
            otv[0] = "Meat"; // заменим на не правильный вариант
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int actual = RezultVar1.calcBonusesVarOne(otv);
            Assert.IsFalse(expected == actual);
        }
        [TestMethod]
        public void calcBonusesVarOne_InputString() // проверяем, что возвращаемое значение инт
        {
            string[] otv = new string[17];
            otv[0] = "Meat"; // заменим на не правильный вариант
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int expected = RezultVar1.calcBonusesVarOne(otv);
            Assert.IsInstanceOfType(expected, typeof(int));
        }
        [TestMethod]
        public void calcBonusesVarOne_InputInt() // проверяем, что возвращаемое значение не  инт,а стринг
        {
            string[] otv = new string[17];
            otv[0] = "Meat"; // заменим на не правильный вариант
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int expected = RezultVar1.calcBonusesVarOne(otv);
            Assert.IsNotInstanceOfType(expected, typeof(string));
        }
        [TestMethod]
        public void calcBonusesVarOne_IsNotNull() // проверяем, что возвращаемое значение не  null
        {
            string[] otv = new string[17];
            otv[0] = "Meat"; // заменим на не правильный вариант
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            int expected = RezultVar1.calcBonusesVarOne(otv);
            Assert.IsNotNull(expected);
        }
        [TestMethod]
        public void calcBonusesVarOne_IsNotException() // проверяем, что метод не дает исключение
        {
            string[] otv = new string[17];
            otv[0] = ""; // заменим на не правильный вариант
            otv[1] = "could read in English";
            otv[2] = "every week";
            otv[3] = "write a book";
            otv[4] = "True";
            otv[5] = "False";
            otv[6] = "True";
            otv[7] = "weather";
            otv[8] = "Pizza";
            otv[9] = "book";
            otv[10] = "interesting";
            otv[11] = "happy";
            otv[12] = "better";
            otv[13] = "-";
            otv[14] = "wrote";
            otv[15] = "was";
            otv[16] = "Does";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => RezultVar1.calcBonusesVarOne(otv)));

            
        }
        [TestMethod]
        public void calcBonusesVarOne_IsNotExceptionTwo() // проверяем, что метод не дает исключение при всех пустых значения
        {
            string[] otv = new string[17];
            otv[0] = "";
            otv[1] = "";
            otv[2] = "";
            otv[3] = "";
            otv[4] = "";
            otv[5] = "";
            otv[6] = "";
            otv[7] = "";
            otv[8] = "";
            otv[9] = "";
            otv[10] = "";
            otv[11] = "";
            otv[12] = "";
            otv[13] = "";
            otv[14] = "";
            otv[15] = "";
            otv[16] = "";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<AssertFailedException>(() => RezultVar1.calcBonusesVarOne(otv)));


        }
        [TestMethod]
        public void calcBonusesVarOne_IsZero() // проверяем, что все ответы false
        {
            int actual = 0;
            string[] otv = new string[17];
            otv[0] = "";
            otv[1] = "";
            otv[2] = "";
            otv[3] = "";
            otv[4] = "";
            otv[5] = "";
            otv[6] = "";
            otv[7] = "";
            otv[8] = "";
            otv[9] = "";
            otv[10] = "";
            otv[11] = "";
            otv[12] = "";
            otv[13] = "";
            otv[14] = "";
            otv[15] = "";
            otv[16] = "";
            int expected = RezultVar1.calcBonusesVarOne(otv);
            Assert.AreEqual(expected, actual);


        }
    }
}
