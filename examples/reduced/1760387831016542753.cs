// Generated by Fuzzlyn on 2018-06-23 21:11:36
// Seed: 1760387831016542753
// Reduced from 8.6 KiB to 0.2 KiB
// Debug: Outputs 255
// Release: Outputs -1
public class Program
{
    public static void Main()
    {
        var vr7 = new byte[]{0};
        vr7[0] = 0;
        var vr10 = vr7[0]--;
        var vr11 = vr7[0];
        int vr12 = vr11;
        System.Console.WriteLine(vr12);
    }
}
