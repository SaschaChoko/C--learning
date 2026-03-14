using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Character pig = new Character();

        pig.Name = "Power Pig Machine";
        pig.Health = 100;

        pig.TakeDamage(30);
        Console.WriteLine(pig.Health);

        pig.GainExperience(120);
        Console.WriteLine(pig.Level);
    }
}
class Character
{
    private int health = 0;
    private int level = 1;
    private int experience = 1;
    public string Name { get ; set; }
    public int Health
    {
        get { return health; }
        set 
        { 
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Incorrect indicators");
            }
            else
            {
                health = value;
            }
        }
    }
    public string Strength { get; set; }
    public int Level
    {
        get { return level; }
    }
    public int Experience
    {
        get { return experience; }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if ( health < 0)
        {
            health = 0;
        }
    }
    public void GainExperience(int xp)
    {
        experience += xp;

        if (experience >= 100)
        {
            level++;
            experience = 0;
        }
    }
}