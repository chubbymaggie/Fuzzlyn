// Generated by Fuzzlyn on 2018-07-14 22:19:29
// Seed: 14284966323200421238
// Reduced from 48.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public long F2;
    public sbyte F4;
}

public class Program
{
    static S0[][, ] s_3 = new S0[][, ]{new S0[, ]{{new S0()}}};
    static long s_7;
    public static void Main()
    {
        ushort vr19 = (ushort)(0 & s_3[0][0, 0].F4);
        s_3[0][0, 0].F2 = s_7;
        System.Console.WriteLine(vr19);
    }
}
