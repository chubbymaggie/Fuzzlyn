// Generated by Fuzzlyn on 2018-06-23 01:10:44
// Seed: 14082648521689103097
// Reduced from 59.9 KiB to 0.2 KiB
// Debug: Outputs 128
// Release: Outputs 65408
public class Program
{
    static ushort s_3;
    static sbyte s_26 = -127;
    public static void Main()
    {
        s_3 = (byte)(1U ^ s_26);
        System.Console.WriteLine(s_3);
    }
}
