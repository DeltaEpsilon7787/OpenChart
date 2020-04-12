﻿namespace OpenChart.Formats.Osu.Data
{
    /// <summary>
    /// A hit object for an osu! beatmap.
    /// </summary>
    ///
    /// TODO: Parse that goddamn type field, and make provisions for extra hit object data (maybe an interface would be good for this?)
    public class OsuHitObject
    {
        /// <summary>
        /// The X position of the object, in osu!pixels.
        /// In osu!mania, this is used to define the column which this hit object should appear in.
        /// In osu!catch, this is used to determine how far across the screen 
        /// In osu!taiko, this field is ignored.
        /// </summary>
        public int XPosition { get; set; }
        
        /// <summary>
        /// The Y position of the object, in osu!pixels.
        /// In all game modes except osu!standard, this field is ignored.
        /// </summary>
        public int YPosition { get; set; }
        
        /// <summary>
        /// The time, in milliseconds, from the start of the beatmap's audio, when this object should appear.
        /// </summary>
        public int Time { get; set; }
    }
}