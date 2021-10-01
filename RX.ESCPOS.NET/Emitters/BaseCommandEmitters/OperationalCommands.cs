﻿using RX.ESCPOS.NET.Emitters.BaseCommandValues;

namespace RX.ESCPOS.NET.Emitters.BaseCommandEmitters
{
    public abstract partial class BaseCommandEmitter : ICommandEmitter
    {
        /* Operational Commands */
        public virtual byte[] Initialize() => new byte[] { Cmd.ESC, Ops.Initialize };

        public virtual byte[] Enable() => new byte[] { Cmd.ESC, Ops.EnableDisable, 1 };

        public virtual byte[] Disable() => new byte[] { Cmd.ESC, Ops.EnableDisable, 0 };
    }
}
