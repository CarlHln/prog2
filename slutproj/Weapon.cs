using System;
using System.Runtime.CompilerServices;
public class Weapon
{
public string name {get; set;}

static void Main (string[] args){
    //different weapons
    Weapon sword = new Weapon("Sword");
    Weapon spear = new Weapon("Spear");
    Weapon dagger = new Weapon("Dagger");
}

private Random generator; 

public Weapon()
{
    //random nunmber for damage
    generator = new Random();
}
public int GetDamage()
{
    //generate damage value 1-20
    return generator.Next(1,20);
}
}
