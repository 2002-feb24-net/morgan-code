using System;
using Xunit;

namespace Serialization.Tests
{
    public class UnitTest1
    {
        // C# has something called "attributes"
        // things ou can put in brackets on top of stuff like methods
        [Fact] // marks this method for xUnit as a test method
        public void TrueShouldBeTrue()
        {
            Assert.True(true);
        }

        // doesn't sa "Fact" so this isn't a test method)
        public void HelperMethod()
        {

        }
    }
}
