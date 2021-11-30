using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        string[] components = line.Split();
        if (components.Length != 7 || !int.TryParse(components[4],out int id) || id <= 0 || id >= 1000 ) 
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return new Sheep(id, components[1], components[6]);
        }
    }
}