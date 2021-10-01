using RX.ESCPOS.NET.Emitters;

namespace RX.ESCPOS.NET.ConsoleTest
{
    public static partial class Tests
    {
        public static byte[][] CashDrawerOpenPin2(ICommandEmitter e) => new byte[][] {
            e.CashDrawerOpenPin2()
        };

        public static byte[][] CashDrawerOpenPin5(ICommandEmitter e) => new byte[][] {
            e.CashDrawerOpenPin5()
        };
    }
}
