namespace Flot.Mvc.ComplexFlot
{
    /// <summary>
    /// The line flot.
    /// </summary>
    public class LineFlot : ComplexFlotBase<LineFlotOptions>
    {
        private readonly LineFlotOptions flotOptions = new LineFlotOptions();

        /// <summary>
        /// Gets the flot type.
        /// </summary>
        public override ComplexFlotType FlotType
        {
            get
            {
                return ComplexFlotType.Line;
            }
        }

        /// <summary>
        /// Gets the flot configuration.
        /// </summary>
        public override LineFlotOptions FlotConfiguration
        {
            get
            {
                return flotOptions;
            }
        }
    }
}