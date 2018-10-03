using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameNamesAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamesAssistant.Tests
{
    [TestClass()]
    public class GeneratorTests
    {
        [TestMethod()]
        public void RandomTest()
        {
            string word = Generator.GenerateRandomPlaceName();

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length >= 3 && word.Length <= 15);

        }

        [TestMethod()]
        public void FixedLengthTest()
        {
            string word = Generator.GenerateRandomPlaceName(15);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 15);

            word = Generator.GenerateRandomPlaceName(25);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 25);

            word = Generator.GenerateRandomPlaceName(1000);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 1000);

            word = Generator.GenerateRandomPlaceName(2);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 2);

            word = Generator.GenerateRandomPlaceName(0);

            Assert.IsTrue(word == null);
            
        }

        [TestMethod()]
        public void FullTest()
        {
            string word = Generator.GenerateRandomPlaceName();

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length >= 3 && word.Length <= 15);

            word = Generator.GenerateRandomPlaceName(15);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 15);

            word = Generator.GenerateRandomPlaceName(25);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 25);

            word = Generator.GenerateRandomPlaceName(1000);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 1000);

            word = Generator.GenerateRandomPlaceName(2);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 2);

            word = Generator.GenerateRandomPlaceName(0);

            Assert.IsTrue(word == null);

            word = Generator.GenerateRandomPlaceName(new char[] { });

            Assert.IsTrue(word == null);


            word = Generator.GenerateRandomPlaceName(new char[] { }, 15);

            Assert.IsTrue(word == null);

            word = Generator.GenerateRandomPlaceName(new char[] { 'a', 'b', 'c', 'd' }, 1);

            Assert.IsTrue(word == null);

            word = Generator.GenerateRandomPlaceName(new char[] { 'a', 'b', 'c', 'd' }, 10);

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length == 10);

            word = Generator.GenerateRandomPlaceName(new char[] { 'a', 'b', 'c', 'd' });

            Assert.IsTrue(word != null);
            Assert.IsTrue(word.Length >= 3 && word.Length <= 15);
        }
    }
}