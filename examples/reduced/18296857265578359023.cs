// Generated by Fuzzlyn on 2018-06-19 06:43:57
// Seed: 18296857265578359023
// Reduced from 44.2 KiB to 0.4 KiB
// Debug: Outputs 3344
// Release: Outputs 0
struct S0
{
    public byte F0;
}

struct S1
{
    public S0 F5;
    public ushort F6;
    public S1(ushort f6): this()
    {
        F6 = f6;
    }
}

struct S2
{
    public S0 F4;
}

public class Program
{
    static S2 s_1;
    static S1 s_6 = new S1(3344);
    public static void Main()
    {
        s_6.F5 = M12();
        System.Console.WriteLine(s_6.F6);
    }

    static S0 M12()
    {
        return s_1.F4;
    }
}
