// Generated by Fuzzlyn on 2018-07-03 22:05:23
// Seed: 6845155625877578526
// Reduced from 53.7 KiB to 0.2 KiB
// Debug: Outputs 53790
// Release: Outputs -11746
public class Program
{
    static short[] s_6;
    public static void Main()
    {
        s_6 = new short[]{-11746};
        char vr30 = (char)(0U ^ s_6[0]);
        System.Console.WriteLine((int)vr30);
    }
}
