using BowlingGame;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void RollOneZero_ReturnsZero()
        {
            _game.Roll(0);
            Assert.AreEqual(0, _game.Score());
        }

        [Test]
        public void RollAllOnes_Returns20()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _game.Score());
        }

        [Test]
        public void RollASpareThenA3_Returns16()
        {
            RollSpare();
            _game.Roll(3);
            Assert.AreEqual(16, _game.Score());
        }

        [Test]
        public void RollAStrikeThenA3AndA2_Returns20()
        {
            RollStrike();
            _game.Roll(3);
            _game.Roll(2);
            Assert.AreEqual(20, _game.Score());
        }  

        [Test]
        public void RollAPerfectGame_Returns300()
        {
            RollMany(21, 10);
            Assert.AreEqual(300, _game.Score());
        }

        private void RollStrike()
        {
            _game.Roll(10);
        }

        private void RollSpare()
        {
            RollMany(2, 5);
        }

        private void RollMany(int times, int score)
        {
            for (int i = 0; i < times; i++)
            {
                _game.Roll(score);

            }
        }
    }
}