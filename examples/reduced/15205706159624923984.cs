// Generated by Fuzzlyn on 2018-07-18 03:44:43
// Seed: 15205706159624923984
// Reduced from 51.9 KiB to 0.3 KiB
// Debug: Outputs 65518
// Release: Outputs 4294967278
public class Program
{
    static int[] s_1 = new int[]{475777518};
    static sbyte s_2;
    public static void Main()
    {
        s_2 = (sbyte)s_1[0];
        var vr18 = M13();
        ulong vr19 = vr18;
        System.Console.WriteLine(vr19);
    }

    static char M13()
    {
        return (char)(s_2 ^ 0);
    }
}
