// Generated by Fuzzlyn on 2018-07-02 18:52:03
// Seed: 13391472616924261137
// Reduced from 136.8 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public long F4;
}

public class Program
{
    static C0[][, ] s_1 = new C0[][, ]{new C0[, ]{{new C0()}}};
    static uint[, ] s_44 = new uint[, ]{{0}};
    public static void Main()
    {
        var vr49 = s_44[0, 0] / ((s_1[0][0, 0].F4 & 0) | 1);
        var vr50 = s_1[0][0, 0];
    }
}
