// Modified from
// <a href="https://stackoverflow.com/a/38090364/1679537">
// Nikos Baxevanis's answer on Stack Overflow
// </a>
// License :
// <a href="https://creativecommons.org/licenses/by-sa/3.0/">CC BY-SA 3.0</a>

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
