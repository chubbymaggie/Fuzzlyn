// Generated by Fuzzlyn on 2018-06-29 05:40:41
// Seed: 2408555667973261601
// Reduced from 159.2 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[][] s_2 = new ushort[][]{new ushort[]{0}};
    static ulong s_3;
    static char[][, ] s_5 = new char[][, ]{new char[, ]{{'$'}}};
    public static void Main()
    {
        var vr13 = s_5[0][0, 0] & 0;
        var vr14 = s_2[0][0];
        M12(vr13);
    }

    static ulong M12(long arg0)
    {
        char[] var1 = new char[]{'.'};
        return s_3;
    }
}
