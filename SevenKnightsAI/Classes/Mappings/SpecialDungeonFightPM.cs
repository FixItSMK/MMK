﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class SpecialDungeonFightPM
    {
        public static readonly PixelMapping Turn1Of2 = new PixelMapping
        {
            X = 478,
            Y = 21,
            Color = 8157077,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn2Of2 = new PixelMapping
        {
            X = 561,
            Y = 21,
            Color = 8880543,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CheckTurn = new PixelMapping
        {
            X = 583,
            Y = 23,
            Color = 7571274,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ChatBT = new PixelMapping
        {
            X = 928,
            Y = 28,
            Color = 0xd4c27c,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of3 = new PixelMapping
        {
            X = 450,
            Y = 21,
            Color = 0x605c72,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn2Of3 = new PixelMapping
        {
            X = 505,
            Y = 21,
            Color = 0x6a667f,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn3Of3 = new PixelMapping
        {
            X = 560,
            Y = 21,
            Color = 0x74708c,
            Type = MappingType.ANCHOR
        };
    }
}
