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
        private IDoor _door;
        private IUserValidation _uservalidation;
        private IKodeGenerator _kode;

        [SetUp]
        public void SetUp()
        {
            _door = Substitute.For<IDoor>();
            _uservalidation = Substitute.For<IUserValidation>();
            _kode = Substitute.For<IKodeGenerator>();
            _uut = new DoorControlClass();
        }

        [Test]
        public void IsDoorOpen_TestState_ResultIsCorrect()
        {
            Assert.That(_uut.RequestEntry());
        }

    }
}
