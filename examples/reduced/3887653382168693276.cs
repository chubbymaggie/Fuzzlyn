// Generated by Fuzzlyn on 2018-06-27 11:44:05
// Seed: 3887653382168693276
// Reduced from 263.8 KiB to 0.7 KiB
// Debug: Outputs 0
// Release: Outputs 72
struct S0
{
    public sbyte F0;
    public sbyte F1;
    public bool F2;
    public short F3;
}

struct S1
{
    public S0 F1;
    public S0 F2;
    public S0 F3;
    public short F4;
    public S1(short f4): this()
    {
        F4 = f4;
    }
}

struct S5
{
    public S1 F4;
    public S5(S1 f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S5 s_9 = new S5(new S1(-26552));
    static S1[, ] s_19 = new S1[, ]{{new S1(0)}};
    public static void Main()
    {
        s_19[0, 0].F1 = M10();
        System.Console.WriteLine(s_19[0, 0].F2.F0);
    }

    static S0 M10()
    {
        return s_9.F4.F3;
    }
}
