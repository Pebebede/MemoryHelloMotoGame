  using NUnit.Framework;

  [TestFixture]
    public class WinConditionTest
    {
        

        [Test]
        public void shouldNotBeMet_WhenNotGuessed()
        {
            List<Guess> guesses = new List<Guess>();
            guesses.Add(Guess(false));
            guesses.Add(Guess(false));
            guesses.Add(Guess(false));


            var winCondition = new WinCondition(guesses);

            var result = winCondition.HasBeenMet();
            
            Assert.IsFalse(result);
        }

       [Test]
        public void shouldNotBeMet_WhenFewGuessed()
        {
            List<Guess> guesses = new List<Guess>();
            guesses.Add(Guess(true));
            guesses.Add(Guess(true));
            guesses.Add(Guess(false));


            var winCondition = new WinCondition(guesses);

            var result = winCondition.HasBeenMet();
            
            Assert.IsFalse(result);
        }

       [Test]
        public void shouldBeMet_WhenAllGuessed()
        {
            List<Guess> guesses = new List<Guess>();
            guesses.Add(Guess(true));
            guesses.Add(Guess(true));
            guesses.Add(Guess(true));


            var winCondition = new WinCondition(guesses);

            var result = winCondition.HasBeenMet();
            
            Assert.IsTrue(result);
        }


        Guess Guess(bool guessed){
            var guess =new Guess(new Position(new PositionRow(1,'a'),1), new Word(""));
            guess.state.wasGuessed = guessed;
            return guess;
        }
    }