// Generated by Fuzzlyn v1.1 on 2018-08-04 04:07:47
// Seed: 15820047086961168775
// Reduced from 419.1 KiB to 0.6 KiB
// Debug: Outputs False
// Release: Outputs True
struct S0
{
    public bool F0;
    public uint F1;
    public S0(bool f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public S0 F0;
    public C0(S0 f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static S0[] s_2;
    static C0 s_5 = new C0(new S0(true));
    public static void Main()
    {
        s_2 = new S0[]{new S0(false)};
        ref S0 vr6 = ref s_2[0];
        vr6 = s_5.F0;
        M4() = s_2[0];
        System.Console.WriteLine(s_2[0].F0);
    }

    static ref S0 M4()
    {
        s_2 = new S0[]{new S0(false)};
        return ref s_2[0];
    }
}
