using System.Runtime.InteropServices;

namespace Flot.Mvc.DataStructures
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct RGBA
    {
        [FieldOffset(0)]
        public uint PackedValue;

        [FieldOffset(0)]
        public byte R;

        [FieldOffset(1)]
        public byte G;

        [FieldOffset(2)]
        public byte B;

        [FieldOffset(3)]
        public byte A;

        public RGBA(uint packedValue) : this()
        {
            PackedValue = packedValue;
        }

        public RGBA(byte r, byte g, byte b, byte a) : this()
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public override string ToString()
        {
            return string.Format("rgba({0}, {1}, {2}, {3})", R, G, B, A * 0.00390625); // Alpha Range Conversion: 0-255 to 0-1
        }
    }
}
