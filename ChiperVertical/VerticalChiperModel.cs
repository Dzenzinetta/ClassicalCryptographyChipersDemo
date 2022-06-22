﻿using System.Collections.Generic;

namespace ChiperVertical
{
    public class ChiperVerticalShiftModel
    {
        public string TextFromConsole { get; set; }

        public int TextLength { get; set; }

        public List<int> VerticalKeyFromConsole { get; set; } = new List<int>();

        public int KeyLength { get; set; }

        public char[,] MatrixForVerticalChiper { get; set; }

        public int MatrixColumnCount { get; set; }

        public int MatrixRowCount { get; set; }

    }
}
