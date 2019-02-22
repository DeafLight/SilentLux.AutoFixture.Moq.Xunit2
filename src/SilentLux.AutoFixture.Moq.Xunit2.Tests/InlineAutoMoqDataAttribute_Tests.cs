using FluentAssertions;
using SilentLux.AutoFixture.Moq.Xunit2.Tests.Artifacts;
using Xunit;

namespace SilentLux.AutoFixture.Moq.Xunit2.Tests
{
    public class InlineAutoMoqDataAttribute_Tests
    {
        public class When_given_no_arguments
        {
            [Theory]
            [InlineAutoMoqData]
            public void Should_inject_mocks(IInterface foo)
            {
                foo.Should().NotBeNull();
            }

            [Theory]
            [InlineAutoMoqData]
            public void Should_inject_instances(AbstractType foo)
            {
                foo.Should().NotBeNull();
            }
        }

        public class When_given_some_arguments
        {
            [Theory]
            [InlineAutoMoqData(1)]
            public void Should_inject_mocks(
                int number,
                IInterface foo
            )
            {
                number.Should().Be(1);
                foo.Should().NotBeNull();
            }

            [Theory]
            [InlineAutoMoqData(1)]
            public void Should_inject_instances(
                int number,
                AbstractType foo
            )
            {
                number.Should().Be(1);
                foo.Should().NotBeNull();
            }

            [Theory]
            [InlineAutoMoqData(1)]
            [InlineAutoMoqData(2)]
            public void Should_inject_mocks_and_instances(
                int number,
                AbstractType foo1,
                IInterface foo2
            )
            {
                number.Should().BePositive();
                foo1.Should().NotBeNull();
                foo2.Should().NotBeNull();
            }
        }

    }
}
