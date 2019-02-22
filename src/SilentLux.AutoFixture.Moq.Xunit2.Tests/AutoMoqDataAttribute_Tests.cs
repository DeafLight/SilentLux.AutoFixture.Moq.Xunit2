using FluentAssertions;
using Moq;
using SilentLux.AutoFixture.Moq.Xunit2.Tests.Artifacts;
using System;
using Xunit;
using static LanguageExt.Prelude;

namespace SilentLux.AutoFixture.Moq.Xunit2.Tests
{
    public class AutoMoqDataAttribute_Tests
    {
        public class When_given_an_interface
        {
            [Theory]
            [AutoMoqData]
            public void Should_create_a_mocked_implementation(IInterface foo)
            {
                foo.Should().NotBeNull();
                Mock.Get(foo).Should().NotBeNull();
            }
        }

        public class When_given_an_abstract_class
        {
            [Theory]
            [AutoMoqData]
            public void Should_create_a_mocked_implementation(AbstractType foo)
            {
                foo.Should().NotBeNull();
                Mock.Get(foo).Should().NotBeNull();
            }
        }

        public class When_given_a_concrete_class
        {
            [Theory]
            [AutoMoqData]
            public void Should_instantiate_it(ConcreteType foo)
            {
                foo.Should().NotBeNull();
                act(() => Mock.Get(foo)).Invoking(x => x())
                    .Should().Throw<ArgumentException>();
            }
        }
    }
}
