﻿using RX.ESCPOS.NET.Emitters.BaseCommandValues;
using RX.ESCPOS.NET.Emitters.Enums;

namespace RX.ESCPOS.NET.Emitters.BaseCommandEmitters
{
    public abstract partial class BaseCommandEmitter : ICommandEmitter
    {
        /* Character Commands */
        public virtual byte[] SetStyles(PrintStyle style) => new byte[] { Cmd.ESC, Chars.StyleMode, (byte)style };

        public virtual byte[] LeftAlign() => new byte[] { Cmd.ESC, Chars.Alignment, (byte)Align.Left };

        public virtual byte[] CenterAlign() => new byte[] { Cmd.ESC, Chars.Alignment, (byte)Align.Center };

        public virtual byte[] RightAlign() => new byte[] { Cmd.ESC, Chars.Alignment, (byte)Align.Right };

        public virtual byte[] RightCharacterSpacing(int spaceCount) => new byte[] { Cmd.ESC, Chars.RightCharacterSpacing, (byte)spaceCount };

        public virtual byte[] CodePage(CodePage codePage) => new byte[] { Cmd.ESC, Chars.CodePage, (byte)codePage };

        public virtual byte[] Color(Color color) => new byte[] { Cmd.ESC, Chars.Color, (byte)color };
    }
}
