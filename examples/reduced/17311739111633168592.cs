// Generated by Fuzzlyn on 2018-07-09 19:56:45
// Seed: 17311739111633168592
// Reduced from 119.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public sbyte F4;
}

class C0
{
    public S0 F0;
    public short F2;
    public S0 F5;
}

public class Program
{
    static C0[, ] s_2 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        var vr9 = (uint)(0 & s_2[0, 0].F5.F4);
        var vr10 = s_2[0, 0].F2;
        M3(vr9);
    }

    static S0 M3(uint arg0)
    {
        uint[] var0 = new uint[]{0};
        return s_2[0, 0].F0;
    }
}
