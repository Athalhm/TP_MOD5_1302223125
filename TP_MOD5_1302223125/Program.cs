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
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}
public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}