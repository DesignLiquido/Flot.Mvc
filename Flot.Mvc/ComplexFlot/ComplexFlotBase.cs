namespace Flot.Mvc.ComplexFlot
{
    /// <summary>
    /// The complex flot base.
    /// </summary>
    public abstract class ComplexFlotBase<TComplexFlotOptions> 
        where TComplexFlotOptions : ComplexFlotOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexFlotBase"/> class.
        /// </summary>
        protected ComplexFlotBase()
        {
            this.ComplexData = new ComplexData();
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public ComplexData ComplexData
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the flot type.
        /// </summary>
        public abstract ComplexFlotType FlotType
        {
            get;
        }

        /// <summary>
        /// Gets the flot configuration.
        /// </summary>
        public abstract TComplexFlotOptions FlotConfiguration
        {
            get;
        }
    }
}