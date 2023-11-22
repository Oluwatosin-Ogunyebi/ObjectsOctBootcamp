using System.Diagnostics;

public static class Utilities
{
    public static string DEVICE_ID;

    public static void ShowDeviceID(string value)
    {
        DEVICE_ID = value;
    }

    public static int CalculateSomeValue(int valA, int valB)
    {
        return (valA + valB) % valB;
    }
}
