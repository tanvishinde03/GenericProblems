using GenericProblems;

namespace GenericTestCase
{
    public class Tests
    {
        FindMaxGenric<int> genericMethodForInt = new FindMaxGenric<int>();
        FindMaxGenric<double> genericMethodForDouble = new FindMaxGenric<double>();

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
    }
}