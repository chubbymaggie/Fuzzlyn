// Generated by Fuzzlyn on 2018-07-15 10:46:03
// Seed: 15583369088342397401
// Reduced from 2.1 KiB to 0.2 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static short s_1;
    public static void Main()
    {
        char vr0 = (char)(0 % ((0 & (M1() % -1)) | 1));
    }

    static long M1()
    {
        s_1 = s_1;
        return -9223372036854775808L;
    }
}
