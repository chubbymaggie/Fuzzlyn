// Generated by Fuzzlyn on 2018-07-28 05:10:44
// Seed: 12003095026352561180
// Reduced from 52.7 KiB to 0.2 KiB
// Debug: Outputs 65443
// Release: Outputs 4294967203
public class Program
{
    static sbyte s_5 = -93;
    public static void Main()
    {
        uint[] vr24 = new uint[]{0};
        ulong vr25 = (char)(s_5 | 2U);
        vr24[0] ^= (uint)vr25;
        System.Console.WriteLine(vr24[0]);
    }
}
