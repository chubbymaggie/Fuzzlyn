// Generated by Fuzzlyn on 2018-07-06 04:24:28
// Seed: 12271441892892804228
// Reduced from 6.7 KiB to 0.2 KiB
// Debug: Outputs 4294967255
// Release: Outputs 215
public class Program
{
    static long s_1 = -3106538083251726377L;
    public static void Main()
    {
        char vr0 = (char)(sbyte)s_1;
        s_1 = vr0;
        System.Console.WriteLine(s_1);
    }
}
