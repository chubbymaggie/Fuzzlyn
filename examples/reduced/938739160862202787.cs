// Generated by Fuzzlyn on 2018-07-03 17:23:26
// Seed: 938739160862202787
// Reduced from 173.3 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static uint[] s_1 = new uint[]{0};
    static uint s_5;
    public static void Main()
    {
        var vr70 = s_5--;
        uint vr71 = s_5;
        char vr72 = (char)(sbyte)vr71;
        System.Console.WriteLine((int)vr72);
    }
}
