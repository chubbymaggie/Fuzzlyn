// Generated by Fuzzlyn on 2018-07-02 12:28:36
// Seed: 8643771865977492784
// Reduced from 84.4 KiB to 0.3 KiB
// Debug: Outputs 65503
// Release: Outputs 4294967263
public class Program
{
    static sbyte s_24 = -101;
    public static void Main()
    {
        char vr11 = (char)M34();
        long vr13 = vr11;
        System.Console.WriteLine(vr13);
    }

    static ushort M34()
    {
        return (ushort)(s_24 | 'N');
    }
}
