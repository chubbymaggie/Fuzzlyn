// Generated by Fuzzlyn on 2018-07-24 10:13:52
// Seed: 1411929851457196747
// Reduced from 44.9 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public byte F2;
    public ulong F5;
}

public class Program
{
    static S0[, ] s_6 = new S0[, ]{{new S0()}};
    public static void Main()
    {
        ulong vr14 = (ulong)(s_6[0, 0].F2 & 0);
        s_6[0, 0].F5 = vr14;
    }
}
