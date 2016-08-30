namespace Flot.Mvc.ComplexFlot
{
    /// <summary>
    /// The radar flot.
    /// </summary>
    public class RadarFlot : ComplexFlotBase<RadarFlotOptions>
    {
        private readonly RadarFlotOptions flotOptions = new RadarFlotOptions();

        /// <summary>
        /// Gets the flot type.
        /// </summary>
        public override ComplexFlotType FlotType
        {
            get
            {
                return ComplexFlotType.Radar;
            }
        }

        /// <summary>
        /// Gets the flot configuration.
        /// </summary>
        public override RadarFlotOptions FlotConfiguration
        {
            get
            {
                return flotOptions;
            }
        }
    }
}
