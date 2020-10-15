using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Enums
{
    public enum PaymentType
    {
        Cash,
        CreditCard,
        EFT,
        Note,
        Deposit
    }
    public enum CourseOfferingState
    {
        Waiting,
        Ongoing,
        Finished,
        Canceled
    }

    [Flags]
    public enum Days
    {
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x3,
        Wednesday = 0x4,
        Thursday = 0x5,
        Friday = 0x6,
        Saturday = 0x7
    }
}
