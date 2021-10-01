﻿using RX.ESCPOS.NET.Emitters.BaseCommandValues;

namespace RX.ESCPOS.NET.Emitters.BaseCommandEmitters
{
    public abstract partial class BaseCommandEmitter : ICommandEmitter
    {
        public virtual byte[] ResetLineSpacing() => new byte[] { Cmd.ESC, Whitespace.ResetLineSpacing };

        public virtual byte[] SetLineSpacingInDots(int dots) => new byte[] { Cmd.ESC, Whitespace.LineSpacingInDots, (byte)dots };
    }
}
