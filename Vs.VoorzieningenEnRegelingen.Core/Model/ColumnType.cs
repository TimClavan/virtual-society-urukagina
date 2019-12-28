﻿using System;

namespace Vs.VoorzieningenEnRegelingen.Core.Model
{
    public class ColumnType
    {
        public ColumnType(DebugInfo debugInfo, string name, ColumnTypeEnum type)
        {
            DebugInfo = debugInfo ?? throw new ArgumentNullException(nameof(debugInfo));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Type = type;
        }

        public DebugInfo DebugInfo { get; }
        public string Name { get; }
        public ColumnTypeEnum Type { get; }

        public enum ColumnTypeEnum
        {
            @double,
            formula,
            @string
        }
    }
}
