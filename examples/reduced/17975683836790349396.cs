// Generated by Fuzzlyn on 2018-07-02 14:18:02
// Seed: 17975683836790349396
// Reduced from 149.7 KiB to 0.3 KiB
// Debug: Outputs 65451
// Release: Outputs 4294967211
class C1
{
    public int F0;
}

public class Program
{
    static sbyte s_16 = -85;
    static C1 s_22 = new C1();
    public static void Main()
    {
        long vr11 = (ushort)(((byte)((s_22.F0-- % 1) / 1750407318U) | 1) | s_16);
        System.Console.WriteLine(vr11);
    }
}
