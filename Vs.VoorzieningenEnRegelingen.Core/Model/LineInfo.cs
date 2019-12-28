﻿namespace Vs.VoorzieningenEnRegelingen.Core.Model
{
    public class LineInfo
    {
        public LineInfo(int line, int col, int index)
        {
            Line = line;
            Col = col;
            Index = index;
        }

        public int Line { get; }
        public int Col { get; }
        public int Index { get; }
    }
}
