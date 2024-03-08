using System.ComponentModel.DataAnnotations;

namespace slutproj;

public class Fighter
{
    //properties
    public string name; 

    public int hp = 100;

    public Weapon weapon;

    public double blockchance = 0.2;

    //attack method
    public void Attack(Fighter target)
    {
        //statement
        Console.WriteLine($"{name} attacked {target.name} with {weapon.name}");

        //random value 0-1 
        double randomValue = new Random().NextDouble();

        //if block=true
        if(randomValue < blockchance)
        {
            Console.WriteLine($"{target.name} parried the attack!");
        }

        //if block=false + uses GetDamage 
        else {
            int damage = weapon.GetDamage();
            target.hp -= damage;
            //check for a critical hit
            if(damage > 16){
                Console.WriteLine($"{name} lands a critical hit!");
            }
        //display info 
        Console.WriteLine($"{target.name} takes {damage} damage!");
        }
        //check if target is alive or dead
        if(target.hp <= 0){
            Console.WriteLine($"{target.name} is dead.");
        }
    }
}

