// Generated by Fuzzlyn on 2018-07-05 12:15:01
// Seed: 7511316618705140767
// Reduced from 4.1 KiB to 0.2 KiB
// Debug: Outputs 159
// Release: Outputs -97
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        s_1 = -97;
        char vr1 = (char)(byte)(s_1 ^ 0L);
        System.Console.WriteLine((int)vr1);
    }
}
