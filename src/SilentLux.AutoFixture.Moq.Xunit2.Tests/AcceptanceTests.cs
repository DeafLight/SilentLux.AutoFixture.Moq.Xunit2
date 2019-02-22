using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2.Tests.Artifacts;
using Xunit;

namespace SilentLux.AutoFixture.Moq.Xunit2.Tests
{
    public class AcceptanceTests
    {
        // Source: http://blog.nikosbaxevanis.com/2012/07/31/autofixture-xunit-net-and-auto-mocking/#auto-mocking-using-moq
        [Theory]
        [AutoMoqData]
        [InlineAutoMoqData(2)]
        [InlineAutoMoqData(3, "foo")]
        public void Should_instantiate_all_arguments(
#pragma warning disable xUnit1026 // Theory methods should use all of their parameters
            double d,
#pragma warning restore xUnit1026
            string s,
            IInterface i,
            AbstractType a,
            ConcreteType c)
        {
            // nothing to do with d
            s.Should().NotBeNull();
            i.Should().NotBeNull();
            a.Should().NotBeNull();
            c.Should().NotBeNull();
        }
    }
}
