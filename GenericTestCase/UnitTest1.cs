using GenericProblems;

namespace GenericTestCase
{
    public class Tests
    {
        FindMaxGenric<int> genericMethodForInt = new FindMaxGenric<int>();

        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax_Int()
        {
            int result = genericMethodForInt.GenricValue(20, 10, 17);
            Assert.AreEqual(20, result);
            //Assert.Pass();
        }
    }
}