// Generated by Fuzzlyn on 2018-07-05 16:35:17
// Seed: 13352347342260573575
// Reduced from 66.2 KiB to 0.2 KiB
// Debug: Outputs 42293
// Release: Outputs -23243
public class Program
{
    static short s_1 = -23243;
    static ulong s_2;
    public static void Main()
    {
        s_2 = (char)((long)0 | s_1);
        int vr25 = (int)s_2;
        System.Console.WriteLine(vr25);
    }
}
