// Generated by Fuzzlyn on 2018-07-07 00:13:32
// Seed: 4506273296576048923
// Reduced from 10.5 KiB to 0.2 KiB
// Debug: Outputs -103
// Release: Outputs 153
public class Program
{
    public static void Main()
    {
        byte[] vr7 = new byte[]{153};
        int vr8 = (sbyte)vr7[0];
        System.Console.WriteLine(vr8);
    }
}
