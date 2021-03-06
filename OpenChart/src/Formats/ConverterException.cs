namespace OpenChart.Formats
{
    /// <summary>
    /// An exception that occurs while converting a project to or from a file.
    /// </summary>
    public class ConverterException : FileFormatException
    {
        public ConverterException(string msg) : base(msg) { }
    }
}
