using RX.ESCPOS.NET.Emitters.BaseCommandValues;

namespace RX.ESCPOS.NET.Emitters.BaseCommandEmitters
{
    public abstract partial class BaseCommandEmitter : ICommandEmitter
    {
        /* Display Commands */
        public virtual byte[] Clear() => new byte[] { Display.CLR };
    }
}
