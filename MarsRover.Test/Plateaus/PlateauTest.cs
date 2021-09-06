using MarsRover.Concrete.Plateaus;
using MarsRover.Coordinates;
using MarsRover.Interfaces.Plateaus;
using MarsRover.Test.Base;
using NUnit.Framework;
using Shouldly;
using System;

namespace MarsRover.Test.Plateaus
{
    [TestFixture]
    public class PlateauTest : BaseTest
    {
        #region .setup

        private IPlateau _plateau;

        protected override void SetUp()
        {
            _plateau = new Plateau();
            base.SetUp();
        }

        #endregion

        [Test]
        public void Plateau_GIVENEnterInvalidCoordinate_WHENIsNotValid_THENItShouldBeThrowsException()
        {
            Assert.Throws<Exception>(() => _plateau.SetSize(new Coordinate(-1, -2)));
        }

        [Test]
        public void Plateau_GIVENEnterValidCoordinate_WHENSetSizeValid_ShouldBeSuccess()
        {
            _plateau.SetSize(new Coordinate(1, 2));
            _plateau.X.ShouldBe(1);
            _plateau.Y.ShouldBe(2);
        }
    }
}
