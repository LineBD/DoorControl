using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class DoorControlTest
    {
        private DoorControlClass _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new DoorControlClass();
        }

        [Test]
        public void IsDoorOpen_TestState_ResultIsCorrect()
        {
            Assert.That(_uut.RequestEntry());
        }

    }
}
