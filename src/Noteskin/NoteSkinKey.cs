using OpenChart.UI.Asset;

namespace OpenChart.NoteSkin
{
    /// <summary>
    /// Contains the image assets for a single key (column).
    /// </summary>
    public class NoteSkinKey
    {
        /// <summary>
        /// The receptor image. The receptor is where a note is hit.
        /// </summary>
        public readonly Image Receptor;

        /// <summary>
        /// The tap note image. A tap note is a regular note that doesn't have release timing.
        /// </summary>
        public readonly Image TapNote;

        /// <summary>
        /// The hold note image. A hold note is a note that must be held after the initial hit.
        /// </summary>
        public readonly Image HoldNote;

        /// <summary>
        /// The hold note body image. The hold note body represents how long a hold note must
        /// be held. The image is tiled and not stretched.
        /// </summary>
        public readonly Image HoldNoteBody;
    }
}
