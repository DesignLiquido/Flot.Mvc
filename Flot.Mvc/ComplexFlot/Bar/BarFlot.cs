namespace Flot.Mvc.ComplexFlot
{
    /// <summary>
    /// The bar flot.
    /// </summary>
    public class BarFlot : ComplexFlotBase<BarFlotOptions>
    {
        private readonly BarFlotOptions flotOptions = new BarFlotOptions();

        /// <summary>
        /// Gets the flot type.
        /// </summary>
        public override ComplexFlotType FlotType
        {
            get
            {
                return ComplexFlotType.Bar;
            }
        }

        /// <summary>
        /// Gets the flot configuration.
        /// </summary>
        public override BarFlotOptions FlotConfiguration
        {
            get
            {
                return flotOptions;
            }
        }
    }
}
