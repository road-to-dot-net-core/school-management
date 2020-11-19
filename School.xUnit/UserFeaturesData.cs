using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace School.xUnit
{
    public class UserFeaturesData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "A4EB39A4-3E62-4046-8023-014CE2B1EDCF", "GetAllUsers", false };
            yield return new object[] { "A51FFEEF-6153-4401-9C0D-01E48AA1279E", "GetAllUsers", false };
            yield return new object[] { "C0522D03-16B0-4CC4-9E09-2EE2A0945B79", "GetAllUsers", false };
            yield return new object[] { "BB3164C9-B6FA-4FE3-8F9C-98CF60B31DB8", "CreateUser", false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

      
    }
}
