using GenericProblems;

namespace GenericTestCase
{
    public class Tests
    {
        FindMaxGenric<int> genericMethodForInt = new FindMaxGenric<int>();
        FindMaxGenric<double> genericMethodForDouble = new FindMaxGenric<double>();
        FindMaxGenric<string> genericMethodForString = new FindMaxGenric<string>();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_Int()
        {
            int result = genericMethodForInt.GenricValue(20, 10, 17);
            Assert.AreEqual(20, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax_Int()
        {
            int result = genericMethodForInt.GenricValue(20, 10, 17);
            Assert.AreEqual(10, result);
            //Assert.Pass();
        }
        [Test]

        public void GivenMaxFirstNum_WhenAnalysed_ShoulReturnThirdMax_Int()
        {
            int result = genericMethodForInt.GenricValue(20, 10, 17);
            Assert.AreEqual(17, result);
            //Assert.Pass();

        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnfirstMax_double()
        {
            double result = genericMethodForDouble.GenricValue(26.7, 34.8, 19.9);
            Assert.AreEqual(34.8, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax_double()
        {
            double result = genericMethodForDouble.GenricValue(26.7, 34.8, 19.9);
            Assert.AreEqual(26.7, result);
            //Assert.Pass();

        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnthridMax_double()
        {
            double result = genericMethodForDouble.GenricValue(26.7, 34.8, 19.9);
            Assert.AreEqual(19.9, result);
            //Assert.Pass();

        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_string()
        {
            string result = genericMethodForString.GenricValue("Indore", "Bhopal", "Ujjain");
            Assert.AreEqual("Indore", result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax_string()
        {
            string result = genericMethodForString.GenricValue("Indore", "Bhopal", "Ujjain");
            Assert.AreEqual("Ujjain", result);
            //Assert.Pass();
        }
    }
}