using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTestUnitaires.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledby_UserIsAdmin_ReturnTrue()
        {

            var admin = new User { IsAdmin = true };
            var user = new User { IsAdmin = false };
            var reservation = new Reservation(user);

            var result = reservation.CanBeCancelledBy(admin);

            Assert.IsTrue(result);

        }


        [TestMethod]
        public void CanBeCancelledby_UserIsMadeBy_ReturnTrue()
        {
            var userMade = new User { IsAdmin = false };
            var reservation = new Reservation(userMade);

            var result = reservation.CanBeCancelledBy(userMade);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminAndNotMadeBy_ReturnsFalse()
        {
            var madeByUser  = new User { IsAdmin = false };
            var admin = new User { IsAdmin = false };
            var reservation = new Reservation(madeByUser);

            var result = reservation.CanBeCancelledBy(admin);

            Assert.IsFalse(result);

        }
    }
}
