// Generated by Fuzzlyn on 2018-07-10 08:58:34
// Seed: 3237891599245312638
// Reduced from 77.4 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[, ] s_1 = new long[, ]{{0}};
    public static void Main()
    {
        var vr21 = new byte[]{0};
        var vr22 = 0 >= ((M3() & 0) ^ s_1[0, 0]);
        M5(vr21, vr22);
    }

    static long M3()
    {
        return s_1[0, 0];
    }

    static byte M5(byte[] arg0, bool arg3)
    {
        return arg0[0]--;
    }
}
