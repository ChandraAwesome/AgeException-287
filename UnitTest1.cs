namespace AgeException

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            {  //Arrange
                DataStructures.Exception_Assignment.Exception_Problems testing = new DataStructures.Exception_Assignment.Exception_Problems();
                //DataStructures.Exception_Assignment.Exception_Problems.Age(45);
                testing.Age(45);
                Assert.AreEqual("Test Passed ",testing);
            }

        }
    }
}