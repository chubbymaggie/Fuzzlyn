// Generated by Fuzzlyn on 2018-07-22 12:18:56
// Seed: 5016764204710220759
// Reduced from 27.2 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short[, ] s_1 = new short[, ]{{0}};
    static int[][] s_2 = new int[][]{new int[]{0}};
    public static void Main()
    {
        ulong vr1 = (byte)(0 & s_1[0, 0]);
        s_2[0][0] = (char)vr1;
    }
}
