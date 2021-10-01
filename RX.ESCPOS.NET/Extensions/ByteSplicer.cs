using RX.ESCPOS.NET.Utils;

namespace RX.ESCPOS.NET.Extensions
{
    public static class ByteSplicer
    {
        public static byte[] Combine(params byte[][] byteArrays)
        {
            ByteArrayBuilder builder = new ByteArrayBuilder();
            foreach (var byteArray in byteArrays)
            {
                builder.Append(byteArray);
            }
            return builder.ToArray();
        }
    }
}
