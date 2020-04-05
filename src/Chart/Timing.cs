using System;

namespace OpenChart.Chart
{
    /// <summary>
    /// The base class for chart objects that are timing-based.
    /// </summary>
    public class Timing
    {
        float _beat;

        /// <summary>
        /// The beat number. The time that this occurs during the chart is dependent on
        /// the BPM changes that come before it.
        /// </summary>
        public float Beat
        {
            get => _beat;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Beat cannot be negative.");
                }

                _beat = value;
            }
        }

        public Timing(float beat)
        {
            Beat = beat;
        }
    }
}