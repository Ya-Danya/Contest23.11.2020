using System;
using System.Collections.Generic;

public class Grassland
{
    List<Sheep> Sheeps { get; set; }

    public Grassland(List<Sheep> sheeps)
    {
        Sheeps = sheeps;
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> evensheeps = new List<Sheep>(); ;

        for (int i = 0; i < Sheeps.Count; i++)
        {
            if (Sheeps[i].Id % 2 == 0)
            {
                evensheeps.Add(Sheeps[i]);
            }
        }
        return evensheeps;
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> oddsheeps = new List<Sheep>();

        for (int i = 0; i < Sheeps.Count; i++)
        {
            if (Sheeps[i].Id % 2 == 1)
            {
                oddsheeps.Add(Sheeps[i]);
            }
        }
        return oddsheeps;
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> sheepswhithname = new List<Sheep>();
        for (int i = 0; i < Sheeps.Count; i++)
        {
            if (Sheeps[i].Name.Contains(name))
            {
                sheepswhithname.Add(Sheeps[i]);
            }
        }
        return sheepswhithname;
    }
}