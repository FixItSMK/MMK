﻿using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        // Just a point on the TapToPlay screen to detect it.
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 90,
            Y = 416,
            Color = 14861437,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 477,
            Y = 486,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}