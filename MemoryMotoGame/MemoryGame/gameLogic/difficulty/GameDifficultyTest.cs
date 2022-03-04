  using NUnit.Framework;

  [TestFixture]
    public class GameDifficultyFactoryTest
    {
        private GameDifficultyFactory tested;

        [SetUp]
        public void SetUp()
        {
            tested = new GameDifficultyFactory();
        }

        [Test]
        public void shouldEasyDifficulty_have4Pair()
        {
            var difficulty = Difficulty.Easy;

            var result = tested.Create(difficulty);
            
            Assert.AreEqual(result.GetNumberOfWords(), 4);
        }

        [Test]
        public void shouldEasyDifficulty_have10Chances()
        {
            var difficulty = Difficulty.Easy;

            var result = tested.Create(difficulty);
            
            Assert.AreEqual(result.GetChances(), 10);
        }

             [Test]
        public void shouldEasyDifficulty_have8Pair()
        {
            var difficulty = Difficulty.Hard;

            var result = tested.Create(difficulty);
            
            Assert.AreEqual(result.GetNumberOfWords(), 8);
        }
        
        [Test]
        public void shouldHardDifficulty_have15Chances()
        {
            var difficulty = Difficulty.Hard;

            var result = tested.Create(difficulty);
            
            Assert.AreEqual(result.GetChances(), 15);
        }
    }