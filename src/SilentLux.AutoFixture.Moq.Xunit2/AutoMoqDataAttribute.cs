// Modified from
// <a href="https://stackoverflow.com/a/38090364/1679537">
// Nikos Baxevanis's answer on Stack Overflow
// </a>
// License :
// <a href="https://creativecommons.org/licenses/by-sa/3.0/">CC BY-SA 3.0</a>

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
