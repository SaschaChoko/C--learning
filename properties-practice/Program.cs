using System;
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
            int newHealth = value;

            if (newHealth < 0)
            {
                newHealth = 0;
            }

            if (newHealth > 100)
            {
                newHealth = 100;
            }

            health = newHealth;
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
        if (damage <= 0)
        {
            damage = 0;
        }
        else
        {
            if (health < damage)
            {
                health = 0;
            }

            else
            {
                health -= damage;
            }
        }
    }
    public void GainExperience(int xp)
    {
        if (xp < 0)
        {
            xp = 0;
        }
        else
        {
            experience += xp;
        }
        
        bool xpGain = true;

        while(xpGain)
        {
            if (experience >= 100)
            {
                level++;
                experience -= 100;
            }
            else
            {
                xpGain = false;
            }
        }
    }
}