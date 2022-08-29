namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Sadmood_Expecting_Sad_Results()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "object reference not set to an instance of an object.";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);

        }
    }

          }
    
