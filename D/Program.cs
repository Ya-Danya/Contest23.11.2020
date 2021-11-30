using System;
using System.Collections.Generic;
using System.Text;

namespace D
{
    /*
    class Program
    {
        class Soldier
        {
            public int swicher1;
            public int swicher2;
            public Soldier()
            {         
                    swicher1 = 1;
            }
            public string Attack()
            {
                if (swicher1 == 2)
                {
                    return "Shoot from gun and throw a grenade";
                }
                else
                {
                    return "Shoot from gun";
                }
            }
        }

        class CoolerSoldier : Soldier
        {
            public CoolerSoldier()
            {
                swicher1 = 2;
            }
            
        }

        class ManInBlack : Soldier
        {
            public ManInBlack()
            {
                swicher1 = 1;
                swicher2 = 1;
            }

            public string Attack()
            {
                if (swicher2 == 1)
                {
                    return "Shoot from blaster";
                }
                else
                {
                    return "Shoot from blaster and call an army of aliens";
                }
            }
        }

        class ManInBlackBoss : ManInBlack
        {
            public ManInBlackBoss()
            {
                swicher1 = 1;
                swicher2 = 2;
            } 
        }

        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            switch (info[0])
            {
                case "Soldier":
                    Soldier s = null;
                    switch (info[1])
                    {
                        case "Soldier":
                            s = new Soldier();
                            break;
                        case "CoolerSoldier":
                            s = new CoolerSoldier();
                            break;
                        case "ManInBlack":
                            s = new ManInBlack();
                            break;
                        case "ManInBlackBoss":
                            s = new ManInBlackBoss();
                            break;
                        default:
                            throw new ArgumentException();
                    }
                    Console.WriteLine(s.Attack());
                    break;
                case "ManInBlack":
                    ManInBlack mib = null;
                    switch (info[1])
                    {
                        case "ManInBlack":
                            mib = new ManInBlack();
                            break;
                        case "ManInBlackBoss":
                            mib = new ManInBlackBoss();
                            break;
                        default:
                            throw new ArgumentException();
                    }
                    Console.WriteLine(mib.Attack());
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
    */
}
