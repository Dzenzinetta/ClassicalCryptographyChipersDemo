﻿using ChipersUtility;

namespace ChiperAffine
{
    public class ChiperAffineBaseModel : IChiperAffineBaseModel
    {
        public int AddictiveKey { get; set; }

        public int MultiplicativeKey { get; set; }

        public string TextFromConsole { get; set; }

        public string TextAfterChiperManipulations { get; set; }
    }
}
