// Generated by Fuzzlyn on 2018-06-19 09:35:26
// Seed: 6170126382070135123
// Reduced from 8.7 KiB to 0.3 KiB
// Debug: Outputs 65531
// Release: Outputs -5
class C0
{
    public ulong F9;
    public C0(ulong f9)
    {
        F9 = f9;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr5 = new C0(579207563084323569UL);
        var vr6 = (ushort)(sbyte)(vr5.F9 | 10U);
        int vr8 = vr6;
        System.Console.WriteLine(vr8);
    }
}
