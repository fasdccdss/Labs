using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Task
{
    Random rnd = new Random();

    public string GenerateKey(int length, string characters)
    {
        var key = new char[length];

        for (int x = 0; x < length; x++)
        {
            int selected = RandomNumberGenerator.GetInt32(characters.Length);
            key[x] = characters[selected];
        }

        return new string(key);
    }

    public static uint IpConverter(string ip = "127.0.0.1")
    {
        var parts = ip.Split('.');

        uint a = byte.Parse(parts[0]);
        uint b = byte.Parse(parts[1]);
        uint c = byte.Parse(parts[2]);
        uint d = byte.Parse(parts[3]);

        return (a << 24) | (b << 16) | (c << 8) | d;
    }

}


public class iface
{
    public void ABC(int x, int y) { }
    public void DEF(string z) { }
    public void GHI(float g, float d, byte f) {}
}

class Introspector
{
    public static List<(string method_name, int length)> Introspect(object iface)
    {
        var method_list = new List<(string, int)>();

        var type = iface.GetType();

        foreach (var m in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
        {
            if (m.IsSpecialName) continue;

            var param_count = m.GetParameters().Length;

            method_list.Add((m.Name, param_count));
        }

        return method_list;
    }

    public static object[,] ToMatrix(List<(string method_name, int length)> method_list)
    {
        var matrix = new object[method_list.Count, 2];

        for (int x = 0; x < method_list.Count; x++)
        {
            matrix[x, 0] = method_list[x].method_name;
            matrix[x, 1] = method_list[x].length;
        }

        return matrix;
    }
}

public class Program
{
    public static void Main()
    {
        var task = new Task();
        var characters = "abcdefghijklmnopqrstuvwxyz0123456789";
        string key = task.GenerateKey(16, characters);

        Console.WriteLine(key);
        Console.WriteLine(Task.IpConverter("10.0.0.1"));
        Console.WriteLine(Task.IpConverter());

        var matrix = Introspector.ToMatrix(Introspector.Introspect(new iface()));
        Console.WriteLine("[");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var comma = i < matrix.GetLength(0) - 1 ? "," : "";
            Console.WriteLine($"  ['{matrix[i, 0]}', {matrix[i, 1]}]{comma}");
        }
        Console.WriteLine("]");
    }
}