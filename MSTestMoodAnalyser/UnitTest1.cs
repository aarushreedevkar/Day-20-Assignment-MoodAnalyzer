namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summary>
        /// TC1.1:Given Iam in sad mood should Return sad.
        /// </summary>
        [TestMethod]
        public void Given_Sadmood_Expecting_Sad_Results()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
            string expected = "sad";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }

          }
    
