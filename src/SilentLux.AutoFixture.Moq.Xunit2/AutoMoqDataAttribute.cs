using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace SilentLux.AutoFixture.Moq.Xunit2
{
    /// <summary>
    /// Uses AutoFixture (with AutoMoqCustomization) to inject generated data
    /// into the test methods parameters.
    /// </summary>
    /// <remarks>
    /// Source: http://blog.nikosbaxevanis.com/2012/07/31/autofixture-xunit-net-and-auto-mocking/#auto-mocking-using-moq
    /// </remarks>
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() :
            base(() =>
                new Fixture()
                    .Customize(new AutoMoqCustomization()))
        {
        }
    }
}
