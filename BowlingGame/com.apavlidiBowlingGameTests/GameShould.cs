using com.apavlidi.Game;
using Xunit;

namespace BowlingGameTests
{
    public class Tests
    {
        private Game _game;

        public Tests()
        {
            _game = new Game();
        }

        [Fact]
        public void RollABall()
        {
            _game.Roll(0);
            Assert.Equal(_game.Score(), 0);
        }

        [Fact]
        public void CalculateAGutterGame()
        {
            doRoll(20, 0);
            Assert.Equal(_game.Score(), 0);
        }

        [Fact]
        public void CalculateAGameWithAllOnes()
        {
            doRoll(20, 1);
            Assert.Equal(_game.Score(), 20);
        }

        [Fact]
        public void CalculateASpare()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(3);
            doRoll(17, 0);
            Assert.Equal(_game.Score(), 16);
        }

        [Fact]
        public void CalculateForPerfectGame()
        {
            doRoll(20, 10);
            Assert.Equal(_game.Score(), 300);
        }

        [Fact]
        public void CalculateAStrike()
        {
            _game.Roll(10);
            _game.Roll(2);
            _game.Roll(2);
            doRoll(16, 0);
            Assert.Equal(_game.Score(), 18);
        }

        private void doRoll(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _game.Roll(pins);
            }
        }
    }
}