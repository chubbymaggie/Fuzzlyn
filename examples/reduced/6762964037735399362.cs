// Generated by Fuzzlyn on 2018-07-04 18:24:33
// Seed: 6762964037735399362
// Reduced from 196.6 KiB to 0.2 KiB
// Debug: Outputs 32769
// Release: Outputs -32767
public class Program
{
    static short s_1;
    public static void Main()
    {
        s_1 = -32767;
        int vr81 = (char)(s_1 | 0L);
        System.Console.WriteLine(vr81);
    }
}
