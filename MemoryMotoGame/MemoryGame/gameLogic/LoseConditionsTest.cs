using NUnit.Framework;

  [TestFixture]
    public class LoseConditionTest
    {
        

        [Test]
        public void shouldNotBeMet_WhenThereIsStillChance()
        {
            var winCondition = new LoseConditions(new Chances(10));

            var result = winCondition.HasBeenMet();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void shouldNotBeMet_WhenThereIsNoChance()
        {
            var winCondition = new LoseConditions(new Chances(0));

            var result = winCondition.HasBeenMet();
            
            Assert.IsTrue(result);
        }


    }
