// Generated by Fuzzlyn on 2018-06-27 10:34:04
// Seed: 8977523338975466915
// Reduced from 205.4 KiB to 0.7 KiB
// Debug: Outputs -127
// Release: Outputs 0
struct S1
{
    public sbyte F0;
    public char F1;
    public sbyte F2;
    public S1(char f1, sbyte f2): this()
    {
    }
}

struct S2
{
    public S1 F0;
    public sbyte F1;
    public ulong F2;
    public uint F4;
    public S2(S1 f0, sbyte f1, uint f4, bool f5): this()
    {
    }
}

public class Program
{
    static sbyte[] s_12 = new sbyte[]{-127};
    public static void Main()
    {
        S2 vr24;
        vr24.F1 = s_12[0];
        S2 vr25 = M27();
        vr24.F0 = M31();
        vr24.F0 = vr25.F0;
        System.Console.WriteLine(vr24.F1);
    }

    static S2 M27()
    {
        return new S2(new S1('`', 0), 0, 0, false);
    }

    static S1 M31()
    {
        return new S1('_', 0);
    }
}
