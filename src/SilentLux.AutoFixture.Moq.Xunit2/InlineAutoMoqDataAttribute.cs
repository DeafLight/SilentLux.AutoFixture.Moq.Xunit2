using AutoFixture.Xunit2;
using Xunit;

namespace SilentLux.AutoFixture.Moq.Xunit2
{
    /// <summary>
    /// Uses AutoFixture (with AutoMoqCustomization) to inject generated data
    /// into the test methods parameters, along with regular inline test data.
    /// The inline test data parameters will be the first injected parameters
    /// (and must then be placed as first parameters in the method
    /// declaration).
    /// Every parameter that is not fixed as inline test data will be generated
    /// by AutoFixture.
    /// </summary>
    /// <remarks>
    /// Source: http://blog.nikosbaxevanis.com/2012/07/31/autofixture-xunit-net-and-auto-mocking/#auto-mocking-using-moq
    /// </remarks>
    public class InlineAutoMoqDataAttribute : CompositeDataAttribute
    {
        public InlineAutoMoqDataAttribute(params object[] values) :
            base(
                new InlineDataAttribute(values),
                new AutoMoqDataAttribute()
            )
        {
        }
    }
}
