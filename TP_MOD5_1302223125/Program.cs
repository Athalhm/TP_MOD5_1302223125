using System;

public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo Praktikan " + nama);
    }

    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nim = "1302223125";
        halo.SapaUser(nim);
    }
}